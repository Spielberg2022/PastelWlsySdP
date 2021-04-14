using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PastelWlsySdP.Dominio
{
    class ClassPastelWslyS_Dom
    {
        struct Usuario {
            private int codigo;
            private string nome;
            private string identificador;
            private string senha;
            private bool autenticacao;
            private char situacao;
            private int tipo;

            public int Codigo { get => codigo; set => codigo = value; }
            public string Nome { get => nome; set => nome = value; }
            public string Identificador { get => identificador; set => identificador = value; }
            public string Senha { get => senha; set => senha = value; }
            public bool Autenticacao { get => autenticacao; set => autenticacao = value; }
            public char Situacao { get => situacao; set => situacao = value; }
            public int Tipo { get => tipo; set => tipo = value; }
        }
    }
}
