using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using PastelWlsySdP.Dominio;
using PastelWlsySdP.Persistencia;

namespace PastelWlsySdP.Aplicacao
{
    class ClassPastelWslyS_Apl
    {
        public ClassPastelWslyS_Dom gestorWslyS_Dom = new ClassPastelWslyS_Dom();
        public ClassPastelWslyS_Per gestorWslyS_Per = new ClassPastelWslyS_Per();
        public SqlConnection sqlConnection = new SqlConnection();
        public string erro;

        public bool PrimeiroAcesso()
        {
            gestorWslyS_Per.sqlConnection = sqlConnection;

            if (gestorWslyS_Per.ContarUsuarios() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
