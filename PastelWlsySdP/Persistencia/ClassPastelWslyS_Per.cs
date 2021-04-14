using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using PastelWlsySdP.Dominio;

namespace PastelWlsySdP.Persistencia
{
    class ClassPastelWslyS_Per
    {
        public SqlConnection sqlConnection = new SqlConnection();
        public SqlDataAdapter adaptador;
        public SqlCommand comando;
        public DataTable dtUsuarios;
        public string erro;

        public int ContarUsuarios()
        {
            int qtdUsuarios = 0;
            comando = new SqlCommand();
            adaptador = new SqlDataAdapter();
            try
            {
                comando.Connection = sqlConnection;
                comando.CommandText = "SELECT COUNT(codigo) FROM Usuarios";
                adaptador.SelectCommand = comando;

                sqlConnection.Open();
                qtdUsuarios = int.Parse(adaptador.SelectCommand.ExecuteScalar().ToString());
            }
            catch (Exception error)
            {
                erro = error.Message;
            }
            finally
            {
                sqlConnection.Close();
            }

            return qtdUsuarios;
        }
    }
}
