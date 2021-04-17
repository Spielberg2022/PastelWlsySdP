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

        public bool InserirAdmGeral(ClassUsuario_Dom usuario_Dom)
        {
            DataTable usuarios = new DataTable();
            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "INSERT INTO UsuariosTipo (descricao, telas) VALUES ('Administrador','Todas')";
                sqlDataAdapter.InsertCommand = sqlCommand;
                sqlConnection.Open();
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlCommand.CommandText = "INSERT INTO UsuariosTipo (descricao, telas) VALUES ('Usuário','Geral')";
                sqlDataAdapter.InsertCommand = sqlCommand;
                sqlConnection.Open();
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlCommand.CommandText = "SELECT codigo FROM UsuariosTipo WHERE telas like 'Todas'";
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                int cod = int.Parse(sqlDataAdapter.SelectCommand.ExecuteScalar().ToString());
                sqlConnection.Close();

                sqlCommand.Parameters.Add("@nome", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@identificador", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@senha", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@tipo", SqlDbType.Int);
                sqlCommand.Parameters["@nome"].Value = usuario_Dom.Nome;
                sqlCommand.Parameters["@identificador"].Value = usuario_Dom.Identificador;
                sqlCommand.Parameters["@senha"].Value = usuario_Dom.Senha;
                sqlCommand.Parameters["@tipo"].Value = cod;

                sqlCommand.CommandText = "INSERT INTO Usuarios (nome, identificador, senha, tipo) VALUES (@nome,@identificador,@senha,@tipo)";
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                erro = error.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
