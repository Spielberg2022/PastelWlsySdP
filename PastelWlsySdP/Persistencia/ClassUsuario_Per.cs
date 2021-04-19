using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using PastelWlsySdP.Dominio;
using Donini.Crypt;

namespace PastelWlsySdP.Persistencia
{
    class ClassUsuario_Per
    {
        public ClassUsuario_Dom usuario_Dom = new ClassUsuario_Dom();
        public ClassUsuarioTipo_Dom usuarioTipo_Dom = new ClassUsuarioTipo_Dom();
        public SqlConnection sqlConnection = new SqlConnection();
        public UsuariosDataSet usuariosData = new UsuariosDataSet();
        public DataTable usuarios = new DataTable();
        public DataTable usuariosTipo = new DataTable();
        Crypt crypt = new Crypt();
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        public string telasUsuario;
        public string erro;

        public DataTable Localizar(ClassUsuario_Dom usuar_Dom)
        {
            DataTable usuarios = new DataTable();
            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@codigo", SqlDbType.Int);
                sqlCommand.Parameters["@codigo"].Value = usuar_Dom.Codigo;
                sqlDataAdapter.SelectCommand = sqlCommand;

                sqlCommand.CommandText = "SELECT * FROM Usuarios where codigo = @codigo";
                sqlConnection.Open();
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                sqlDataAdapter.Fill(usuarios);
                usuar_Dom.Usuarios = usuarios;
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

        public bool TipoUsuario(int tipo)
        {
            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@codigo", SqlDbType.Int);
                sqlCommand.Parameters["@codigo"].Value = tipo;
                sqlDataAdapter.SelectCommand = sqlCommand;

                sqlCommand.CommandText = "SELECT telas FROM UsuariosTipo where codigo = @codigo";
                sqlConnection.Open();
                telasUsuario = sqlDataAdapter.SelectCommand.ExecuteScalar().ToString();

                //sqlDataAdapter.Fill(usuario_Dom.Usuarios);

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

        public bool TipoUsuario()
        {
            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlDataAdapter.SelectCommand = sqlCommand;

                sqlCommand.CommandText = "SELECT * FROM UsuariosTipo";
                sqlConnection.Open();
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                usuarioTipo_Dom.UsuarioTipos = new DataTable();
                sqlDataAdapter.Fill(usuarioTipo_Dom.UsuarioTipos);

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

        public bool InserirUsuario(ClassUsuario_Dom usuar_Dom)
        {
            usuario_Dom = usuar_Dom;

            crypt = new Crypt(CryptProvider.DES);
            crypt.Key = "Wsly@87";

            DataTable usuarios = new DataTable();
            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.Add("@nome", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@dt_nascimento", SqlDbType.Date);
                sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@cel", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@cep", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@logradouro", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@bairro", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@cidade", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@uf", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@identificador", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@senha", SqlDbType.NVarChar);   
                sqlCommand.Parameters.Add("@tipo", SqlDbType.Int);

                sqlCommand.Parameters["@nome"].Value = usuario_Dom.Nome;
                sqlCommand.Parameters["@dt_nascimento"].Value = usuario_Dom.Dt_nascimento;
                sqlCommand.Parameters["@tel"].Value = usuario_Dom.Tel;
                sqlCommand.Parameters["@cel"].Value = usuario_Dom.Cel;
                sqlCommand.Parameters["@email"].Value = usuario_Dom.Email;
                sqlCommand.Parameters["@cep"].Value = usuario_Dom.Cep;
                sqlCommand.Parameters["@logradouro"].Value = usuario_Dom.Logradouro;
                sqlCommand.Parameters["@bairro"].Value = usuario_Dom.Bairro;
                sqlCommand.Parameters["@cidade"].Value = usuario_Dom.Cidade;
                sqlCommand.Parameters["@uf"].Value = usuario_Dom.Uf;
                sqlCommand.Parameters["@identificador"].Value = usuario_Dom.Identificador;
                sqlCommand.Parameters["@senha"].Value = usuario_Dom.Senha;
                sqlCommand.Parameters["@tipo"].Value = usuario_Dom.Tipo;

                if (usuario_Dom.Foto != null)
                {
                    sqlCommand.Parameters.Add("@foto", SqlDbType.Binary);
                    sqlCommand.Parameters["@foto"].Value = usuario_Dom.Foto;
                    sqlCommand.CommandText = "INSERT INTO Usuarios (nome, dt_nascimento, tel, cel, email, cep, logradouro, bairro, cidade, uf,  identificador, senha, tipo, foto) VALUES (@nome, @dt_nascimento, @tel, @cel, @email, @cep, @logradouro, @bairro, @cidade, @uf, @identificador, '" + crypt.Encrypt(usuario_Dom.Senha) + "', @tipo, @foto)";
                }  
                else
                {
                    sqlCommand.CommandText = "INSERT INTO Usuarios (nome, dt_nascimento, tel, cel, email, cep, logradouro, bairro, cidade, uf,  identificador, senha, tipo) VALUES (@nome, @dt_nascimento, @tel, @cel, @email, @cep, @logradouro, @bairro, @cidade, @uf, @identificador, '" + crypt.Encrypt(usuario_Dom.Senha) + "', @tipo)";
                }
                
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

        public bool Login(ClassUsuario_Dom usuar_Dom)
        {
            usuario_Dom = usuar_Dom;
            usuarios = new DataTable();

            crypt = new Crypt(CryptProvider.DES);
            crypt.Key = "Wsly@87";


            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.Add("@identificador", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@senha", SqlDbType.NVarChar);
                sqlCommand.Parameters["@identificador"].Value = usuario_Dom.Identificador;
                sqlCommand.Parameters["@senha"].Value = crypt.Encrypt(usuario_Dom.Senha);

                sqlCommand.CommandText = "SELECT * FROM Usuarios WHERE identificador = @identificador and senha = @senha";
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                sqlDataAdapter.Fill(usuarios);

                //Habilitar quando for preciso

                //usuario_Dom.Codigo = int.Parse(usuarios.Rows[0]["codigo"].ToString());
                //usuario_Dom.Nome = usuarios.Rows[0]["nome"].ToString();
                //if (usuarios.Rows[0]["dt_nascimento"].ToString() == null || usuarios.Rows[0]["dt_nascimento"].ToString() == "")
                //    usuario_Dom.Dt_nascimento = DateTime.MinValue;
                //else
                //    usuario_Dom.Dt_nascimento = DateTime.Parse(usuarios.Rows[0]["dt_nascimento"].ToString());
                //usuario_Dom.Tel = usuarios.Rows[0]["tel"].ToString();
                //usuario_Dom.Cel = usuarios.Rows[0]["cel"].ToString();
                //usuario_Dom.Email = usuarios.Rows[0]["email"].ToString();
                //usuario_Dom.Cep = usuarios.Rows[0]["cep"].ToString();
                //usuario_Dom.Logradouro = usuarios.Rows[0]["logradouro"].ToString();
                //usuario_Dom.Bairro = usuarios.Rows[0]["bairro"].ToString();
                //usuario_Dom.Cidade = usuarios.Rows[0]["cidade"].ToString();
                //usuario_Dom.Uf = usuarios.Rows[0]["uf"].ToString();
                //usuario_Dom.Identificador = usuarios.Rows[0]["identificador"].ToString();
                //usuario_Dom.Senha = usuarios.Rows[0]["senha"].ToString();
                usuario_Dom.Tipo = int.Parse(usuarios.Rows[0]["tipo"].ToString());
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

        public bool InserirAdmGeral(ClassUsuario_Dom usuar_Dom)
        {
            usuario_Dom = usuar_Dom;

            crypt = new Crypt(CryptProvider.DES);
            crypt.Key = "Wsly@87";
            
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
                //sqlCommand.Parameters.Add("@senha", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@tipo", SqlDbType.Int);
                sqlCommand.Parameters["@nome"].Value = usuario_Dom.Nome;
                sqlCommand.Parameters["@identificador"].Value = usuario_Dom.Identificador;
                //sqlCommand.Parameters["@senha"].Value = usuario_Dom.Senha;
                sqlCommand.Parameters["@tipo"].Value = cod;

                sqlCommand.CommandText = "INSERT INTO Usuarios (nome, identificador, senha, tipo) VALUES (@nome,@identificador,'" + crypt.Encrypt(usuario_Dom.Senha) + "',@tipo)";
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
