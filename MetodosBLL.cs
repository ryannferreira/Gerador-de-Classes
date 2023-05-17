using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace CriadorDeClasse
{
    internal class MetodosBLL
    {
        public static void validaDados(Metodos metodos)
        {
            Erro.setErro(false);

            if(metodos.GetNomeMetodo().Length == 0 )
            {
                Erro.setErro("O preenchimento do nome do método é obrigatório!");
                return;
            }

            if (metodos.GetModificadorAcesso() == "")
            {
                Erro.setErro("Escolha um modificador de acesso para o método!");
                return;
            }

            if (metodos.GetTipoRetorno().Length == 0)
            {
                Erro.setErro("A escolhe do tipo de retorno é obrigatório!");
                return;
            }

        }
    }
}
