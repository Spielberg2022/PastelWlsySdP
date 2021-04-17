using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PastelWlsySdP.Dominio
{
    class ClassUsuarioTipo_Dom
    {
        private int codigo;
        private string descricao;
        private string telas;
        private DataTable usuarioTipos;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Telas { get => telas; set => telas = value; }
        public DataTable UsuarioTipos { get => usuarioTipos; set => usuarioTipos = value; }
    }
}
