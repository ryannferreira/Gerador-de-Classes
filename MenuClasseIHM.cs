using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriadorDeClasse
{
    public partial class MenuClasseIHM : Form
    {
        Classes classes = new Classes();
        public MenuClasseIHM()
        {
            InitializeComponent();
        }

        public void CorretorNome(string nomeClasse)
        {
            tb_nomeClasse.Text = nomeClasse[0].ToString().ToUpper() + nomeClasse.Substring(1).ToLower();
        }

        private void bt_Avancar_Click(object sender, EventArgs e)
        {

            CorretorNome(tb_nomeClasse.Text);

            classes.SetNomeClasse(tb_nomeClasse.Text);
            classes.SetModificadorAcesso(cb_modificadorAcesso.Text);

            if (rb_Asenjo.Checked == true)
            {
                classes.SetPadrao("1");
            }
            else if (rb_LuizAntonio.Checked == true)
            {
                classes.SetPadrao("2");
            }
            else
            {
                classes.SetPadrao("");
            }

            ClassesBLL.ValidaDados(classes);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens(), "Erro!");
            }
            else
            {
                MenuPropriedadeIHM menuPropriedadeIHM = new MenuPropriedadeIHM(classes);
                menuPropriedadeIHM.ShowDialog();
            }
        }

    }
}
