using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaBiblioteca;

namespace CriadorDeClasse
{
    public partial class MenuMetodosIHM : Form
    {
        List<string> listaMetodo = new List<string>();
        Metodos metodos = new Metodos();

        public MenuPropriedadeIHM menuPropriedadeIHM;
        public MenuMetodosIHM(MenuPropriedadeIHM menuPropriedadeIHM)
        {
            InitializeComponent();
            this.menuPropriedadeIHM = menuPropriedadeIHM;
            cb_static3.Enabled = false;
        }

        private void LimpaCampos()
        {
            cb_static3.Checked = false;
            cb_static3.Enabled = false;
        }
        private void cb_modificadorAcesso3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_modificadorAcesso3.SelectedIndex == 0 || cb_modificadorAcesso3.SelectedIndex == 2)
            {
                cb_static3.Enabled = true;
            }
            else 
            {
                cb_static3.Enabled = false;
                cb_static3.Checked = false;
            }
        }

        string aux_static;
        private void bt_adicionarMetodo_Click(object sender, EventArgs e)
        {
            if (cb_static3.Checked == true)
            {
                aux_static = cb_static3.Text + " ";
            }
            else
            {
                aux_static = string.Empty;
            }
            
            metodos.SetNomeMetodo(tb_nomeMetodo.Text);
            metodos.SetArgumento(tb_argumento.Text);
            metodos.SetArgumento(tb_argumento.Text);
            metodos.SetTipoRetorno(cb_retornoMetodo.Text);
            metodos.SetModificadorAcesso(cb_modificadorAcesso3.Text);

            MetodosBLL.validaDados(metodos);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens(), "Erro!");
            }
            else
            {
                listaMetodo.Add(aux_static + metodos.GetModificadorAcesso() + " " + metodos.GetTipoRetorno() + " " + metodos.GetNomeMetodo() + " " + "(" + metodos.GetArgumento() + ")" + " " + "{");

                string aux_codigoMetodo = string.Join(" ", listaMetodo);

                menuPropriedadeIHM.listaCodigo.Add(" ");
                menuPropriedadeIHM.listaCodigo.Add(aux_codigoMetodo);
                menuPropriedadeIHM.listaCodigo.Add(tb_codigoMetodo.Text);
                menuPropriedadeIHM.listaCodigo.Add("}");

                LimpaCampos();
                menuPropriedadeIHM.AtualizaListaCodigo();

                this.Close();
            }
        }
    }
}
