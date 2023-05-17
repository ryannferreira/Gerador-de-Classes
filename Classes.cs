using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDeClasse
{
    internal class Classes
    {
        private string NomeClasse;
        private string ModificadorAcesso;
        private string Padrao;

        public string GetPadrao()
        {
            return Padrao;
        }
        public string GetNomeClasse()
        {
            return NomeClasse;
        }
        public string GetModificadorAcesso()
        {
            return ModificadorAcesso;
        }

        public void SetPadrao (string _padrao)
        {
            Padrao= _padrao;
        }
        public void SetNomeClasse(string _nomeClasse)
        {
            NomeClasse = _nomeClasse;
        }

        public void SetModificadorAcesso(string _modificadorAcesso)
        {
            ModificadorAcesso = _modificadorAcesso;
        }
    }
}
