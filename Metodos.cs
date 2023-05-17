using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDeClasse
{
    internal class Metodos
    {
        private string NomeMetodo;
        private string Argumento;
        private string TipoRetorno;
        private string ModificadorAcesso;

        public string GetTipoRetorno()
        {
            return TipoRetorno;
        }
        public string GetNomeMetodo()
        {
            return NomeMetodo;
        }

        public string GetArgumento()
        {
            return Argumento;
        }

        public string GetModificadorAcesso()
        {
            return ModificadorAcesso;
        }

        public void SetTipoRetorno(string _tipoRetorno)
        {
            TipoRetorno= _tipoRetorno;
        }
        public void SetNomeMetodo(string _nomeMetodo)
        {
            NomeMetodo= _nomeMetodo;
        }

        public void SetArgumento (string _argumento)
        {
            Argumento= _argumento;
        }

        public void SetModificadorAcesso(string _modificadorAcesso)
        {
            ModificadorAcesso = _modificadorAcesso;
        }
    }
}
