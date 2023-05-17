using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriadorDeClasse
{
    internal class ClassesBLL
    {
        public static void ValidaDados(Classes classes)
        {
            Erro.setErro(false);
            if (classes.GetNomeClasse().Length == 0 )
            {
                Erro.setErro("O nome da classe é de preenchimento obrigatório!");
                return;
            }

            if(classes.GetModificadorAcesso().Length == 0) 
            {
                Erro.setErro("Escolha um modificador de acesso para classe!");
                return;
            }

            if(classes.GetPadrao().Length == 0)
            {
                Erro.setErro("Escolha um padrão para os getters e setters!");
                return;
            }

        }
    }
}
