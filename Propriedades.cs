using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriadorDeClasse
{
    internal class Propriedades
    {
        private string NomePropriedade;
        private string TipoPropriedade;
        private string ModificadorAcesso;

        public string GetModificadorAcesso()
        {
            return ModificadorAcesso;
        }
        public string GetNomePropriedade()
        {
            return NomePropriedade;
        }
        public string GetTipoPropriedade()
        {
            return TipoPropriedade;
        }

        public void SetNomePropriedade(string _nomePropriedade)
        {
            NomePropriedade = _nomePropriedade;
        }

        public void SetTipoPropriedade(string _tipoPropriedade)
        {
            TipoPropriedade = _tipoPropriedade;
        }
        public void SetModificadorAcesso(string _modificadorAcesso)
        {
            ModificadorAcesso = _modificadorAcesso;
        }

    }
}
