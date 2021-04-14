using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace PastelWlsySdP.Dominio
{
    class ClassChavesWin_Dom
    {
        private string servidor;
        private string instancia;
        private string autenticacao;
        private string usuario;
        private string senha;
        private string bd;
        private string serial;
        private RegistryKey chave;

        public string Servidor { get => servidor; set => servidor = value; }
        public string Instancia { get => instancia; set => instancia = value; }
        public string Autenticacao
        {
            get => autenticacao;
            set
            {
                autenticacao = value;
                if (autenticacao == "Windows")
                    autenticacao = "Autenticação do Windows";
                else if (autenticacao == "SQL")
                    autenticacao = "Autenticação do SQL";
            }
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Bd { get => bd; set => bd = value; }
        public string Serial { get => serial; set => serial = value; }
        public RegistryKey Chave { get => chave; set => chave = value; }

    }
}
