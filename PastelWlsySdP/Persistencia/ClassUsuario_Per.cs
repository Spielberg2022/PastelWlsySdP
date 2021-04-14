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
    class ClassUsuario_Per
    {
        public ClassUsuario_Dom usuario_Dom = new ClassUsuario_Dom();
        public SqlConnection sqlConnection = new SqlConnection();
        public UsuariosDataSet usuariosData = new UsuariosDataSet();
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        public string erro;

        public DataTable Localizar(ClassUsuario_Dom usuario_Dom)
        {
            DataTable usuarios = new DataTable();
            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@codigo", SqlDbType.Int);
                sqlCommand.Parameters["@codigo"].Value = usuario_Dom.Codigo;
                sqlDataAdapter.SelectCommand = sqlCommand;

                sqlCommand.CommandText = "SELECT * FROM Usuarios where codigo = @codigo";
                sqlConnection.Open();
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                sqlDataAdapter.Fill(usuarios);
                usuario_Dom.Usuarios = usuarios;

                if (usuariosData.Tables.Count > 0)
                    usuariosData.Tables.Remove(usuarios);

                usuariosData.Tables.Add(usuarios);
            }
            catch (Exception error)
            {
                erro = error.Message;
            }
            finally
            {
                sqlConnection.Close();
            }

            return usuarios;
        }
    }
}
