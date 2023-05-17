using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriadorDeClasse
{
    public partial class MenuPropriedadeIHM : Form
    {
        public List<string> listaCodigo = new List<string>();
        public List<string> parametrosDefault = new List<string>();
        Propriedades propriedades = new Propriedades();
        Classes classes = new Classes();

        public void AtualizaListaCodigo()
        {
            lb_estruturaClasse.DataSource = null;
            lb_estruturaClasse.DataSource = listaCodigo;
        }

        public void LimparCamposProp()
        {
            tb_nomePropriedade.Text = "";
            cb_tipoPropriedade.Text = "";
            cb_static.Checked = false;
            cb_modificadorAcesso2.SelectedIndex = -1;
            cb_static.Enabled = false;
            cb_tipoPropriedade.SelectedIndex = -1;
        }

        public void CorretorNome(string nomePropriedade)
        {
            tb_nomePropriedade.Text = tb_nomePropriedade.Text[0].ToString().ToUpper() + tb_nomePropriedade.Text.Substring(1).ToLower();
        }
        internal MenuPropriedadeIHM(Classes classes)
        {
            InitializeComponent();
            this.classes = classes;
            cb_static.Enabled = false;
        }

        public MenuPropriedadeIHM(string codigoMetodo)
        {
            //Construtor utilizado para receber os códigos do menu de métodos e adicionar a lista de códigos

            InitializeComponent();
            listaCodigo.Add(codigoMetodo);
        }

        private void bt_janelaMetodos_Click_(object sender, EventArgs e)
        {
            MenuMetodosIHM menuMetodosIHM = new MenuMetodosIHM(this);

            menuMetodosIHM.ShowDialog();
        }

        private void cb_modificadorAcesso2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_modificadorAcesso2.SelectedIndex == 0 || cb_modificadorAcesso2.SelectedIndex == 2)
            {
                cb_static.Enabled = true;
            }
            else 
            { 
                cb_static.Enabled = false;
                cb_static.Checked = false;
            }

        }

        string aux_static;
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (cb_static.Checked == true)
            {
                aux_static = cb_static.Text + " ";
            }
            else
            {
                aux_static = string.Empty;
            }

            CorretorNome(tb_nomePropriedade.Text);

            propriedades.SetNomePropriedade(tb_nomePropriedade.Text);
            propriedades.SetTipoPropriedade(cb_tipoPropriedade.Text);
            propriedades.SetModificadorAcesso(cb_modificadorAcesso2.Text);

            PropriedadesBLL.ValidaDados(propriedades);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens(), "Erro!");
            }
            else
            {
                switch(classes.GetPadrao())
                {
                    case "2":
                        listaCodigo.Add(aux_static + propriedades.GetModificadorAcesso() + " " + propriedades.GetTipoPropriedade() + " " + propriedades.GetNomePropriedade() + " { get; set; }");
                        break;
                        case "1":
                        listaCodigo.Add(aux_static + cb_modificadorAcesso2.SelectedItem +  " " + propriedades.GetTipoPropriedade() + " " + propriedades.GetNomePropriedade());
                        listaCodigo.Add("");
                        listaCodigo.Add("public" + " " + propriedades.GetTipoPropriedade() + " get" + propriedades.GetNomePropriedade() + "()");
                        listaCodigo.Add("{");
                        listaCodigo.Add(" return" + " " + propriedades.GetNomePropriedade());
                        listaCodigo.Add("}");
                        listaCodigo.Add("");
                        listaCodigo.Add("public void set" + propriedades.GetNomePropriedade() + "(" + propriedades.GetTipoPropriedade() + " " + "_" + propriedades.GetNomePropriedade() + ")");
                        listaCodigo.Add("{");
                        listaCodigo.Add(" " + propriedades.GetNomePropriedade() + "= _" + propriedades.GetNomePropriedade() + ";");
                        listaCodigo.Add("}");
                        break;
                }
                AtualizaListaCodigo();
                LimparCamposProp();
            }
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (listaCodigo.Count == 0)
            {
                MessageBox.Show("Não há código para apagar.", "Aviso!");
            }
            else
            {
                listaCodigo.RemoveAt(lb_estruturaClasse.SelectedIndex);
                AtualizaListaCodigo();
            }
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            if(listaCodigo.Count == 0)
            {
                MessageBox.Show("Não há código para apagar.", "Aviso!");
            }
            else
            {
                listaCodigo.Clear();
                AtualizaListaCodigo();
            }              
        }

        private void bt_gerarClasse_Click(object sender, EventArgs e)
        {
       
            parametrosDefault = new List<string>()
            {
               "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\nusing System.Threading.Tasks;\n\nnamespace Default\n{\n" + classes.GetModificadorAcesso() + " " + "class" + " " + classes.GetNomeClasse() + "{"
            };

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                DialogResult selecionarDiretorio = folderBrowserDialog.ShowDialog();

                if (selecionarDiretorio == DialogResult.OK)
                {
                    string diretorio = Path.Combine(folderBrowserDialog.SelectedPath, classes.GetNomeClasse() + ".cs");

                    using (StreamWriter arquivo = new StreamWriter(diretorio))
                    {
                        var algoritmos = parametrosDefault.Concat(listaCodigo);

                        foreach (var codigoFonte in algoritmos)
                        {
                            arquivo.WriteLine(codigoFonte);
                        }

                        arquivo.Write("\n}\n}");
                    }

                    MessageBox.Show("O arquivo foi salvo com sucesso em: " + diretorio, "Criador de classes");
                }
            }
        }

        
    }
}
