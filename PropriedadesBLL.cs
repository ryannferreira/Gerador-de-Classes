using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDeClasse
{
    internal class PropriedadesBLL
    {
        public static void ValidaDados (Propriedades propriedades)
        {
            Erro.setErro(false);
            if (propriedades.GetNomePropriedade().Length ==0)
            {
                Erro.setErro("O nome da propriedade é obrigatório!");
                return;
            }

            if (propriedades.GetModificadorAcesso() == "")
            {
                Erro.setErro("Escolha um modificador de acesso para propriedade!");
                return;
            }

            if (propriedades.GetTipoPropriedade() == "")
            {
                Erro.setErro("O tipo de propriedade é obrigatório!");
                return;
            }
            
        }
    }
}
