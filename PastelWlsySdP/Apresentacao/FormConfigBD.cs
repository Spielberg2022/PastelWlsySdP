using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

using PastelWlsySdP.Dominio;
using PastelWlsySdP.Aplicacao;


namespace PastelWlsySdP.Apresentacao
{
    public partial class FormConfigBD : Form
    {
		public SqlConnection connection = new SqlConnection();

		ClassChavesWin_Apl chavesWin_Apl = new ClassChavesWin_Apl();
		ClassConfigBD_Apl configBD_Apl = new ClassConfigBD_Apl();
		ClassPastelWslyS_Apl pastelWslyS_Apl = new ClassPastelWslyS_Apl();
		ClassChavesWin_Dom chavesWin_Dom = new ClassChavesWin_Dom();
        ClassConfigBD_Dom bd = new ClassConfigBD_Dom();
        BindingSource relacionamento = new BindingSource();
        char[] pesquisa = { '\\' };
		bool erro;

        public FormConfigBD()
        {
			InitializeComponent();

			testaBd_button_Click();
        }

        private void testaBd_button_Click()
        {
			if (chavesWin_Apl.VerChaves())
			{
				bd.Servidor = chavesWin_Apl.chaves.Servidor;
				bd.Instância = chavesWin_Apl.chaves.Instancia;
				bd.Autenticação = chavesWin_Apl.chaves.Autenticacao;
				bd.Usuário = chavesWin_Apl.chaves.Usuario;
				bd.Senha = chavesWin_Apl.chaves.Senha;
				bd.Bd = chavesWin_Apl.chaves.Bd;

				if (!configBD_Apl.Conectar(bd))
				{
					MessageBox.Show("Erro ao tentar conectar com o banco de dados. Entre em contato com o suporte.\n\n" + configBD_Apl.erro,
											"Erro",
											  MessageBoxButtons.OK,
											 MessageBoxIcon.Error);
					erro = true;
				}
				else
                {
					connection = configBD_Apl.connection;
					okButton_Click();
				}
			}
			else
			{
				MessageBox.Show("Configure a conexão com o banco de dados!",
											"Informação",
											  MessageBoxButtons.OK,
											 MessageBoxIcon.Information);
				erro = true;
				this.Cursor = Cursors.WaitCursor;
				AtualizarServidores();
				this.Cursor = Cursors.Default;
			}
		}

        private void okButton_Click()
        {
			pastelWslyS_Apl.sqlConnection = connection;

			if(!pastelWslyS_Apl.PrimeiroAcesso())
            {
				FormLogin login = new FormLogin();
				login.sqlConnection = connection;
				login.Show();
				this.Hide();
			}
			else
            {
				FormCadUsuario cadUsuario = new FormCadUsuario();
				cadUsuario.sqlConnection = connection;
				cadUsuario.primeiroAcesso = true;
				this.Hide();
				cadUsuario.ShowDialog();
				FormLogin login = new FormLogin();
				login.sqlConnection = connection;
				login.Show();
			}
		}

        void Limpa()
		{
			this.Cursor = Cursors.WaitCursor;
			if (autenticação_comboBox.Text == "Autenticação do Windows" || autenticação_comboBox.Text == "")
			{
				autenticação_comboBox.Text = "Autenticação do Windows";
				usuário_textBox.Enabled = false;
				senha_textBox.Enabled = false;
			}
			else
			{
				autenticação_comboBox.Text = "Autenticação do SQL";
				usuário_textBox.Enabled = true;
				senha_textBox.Enabled = true;
			}
			usuário_textBox.ResetText();
			senha_textBox.ResetText();
			bd_comboBox.Text = "";
			bd_comboBox.DataSource = null;
			usuário_textBox.Focus();
			this.Cursor = Cursors.Default;
		}

		void PreencheDados()
		{
			bd = new ClassConfigBD_Dom();
			bd.Servidor = servidor_comboBox.Text;
			bd.Instância = instancia_comboBox.Text;
			bd.Autenticação = autenticação_comboBox.Text;
			bd.Usuário = usuário_textBox.Text;
			bd.Senha = senha_textBox.Text;
			bd.Bd = bd_comboBox.Text;
		}

		void AtualizarServidores()
		{
			this.Cursor = Cursors.WaitCursor;
			relacionamento.DataSource = configBD_Apl.pegaServidores();
			servidor_comboBox.DisplayMember = "ServerName";
			servidor_comboBox.DataSource = relacionamento;
			instancia_comboBox.DisplayMember = "InstanceName";
			instancia_comboBox.DataSource = relacionamento;
			this.Cursor = Cursors.Default;
			servidor_comboBox.Focus();
		}

		void Bd_comboBoxEnter(object sender, EventArgs e)
		{
			bd_comboBox.Text = "";
			PreencheDados();
			
			this.Cursor = Cursors.WaitCursor;
			if (autenticação_comboBox.Text != "")
			{
				if (autenticação_comboBox.Text == "Autenticação do Windows")
				{
					if (configBD_Apl.Conectar(bd))
						bd_comboBox.DataSource = configBD_Apl.pegaBDs();
					else
					{
						MessageBox.Show("Usuário do Windows sem permissão de entrada.\n\n" + configBD_Apl.erro,
										"Atenção: ",
										  MessageBoxButtons.OK,
										 MessageBoxIcon.Exclamation);
						Limpa();
					}
				}
				else
				{
					if (usuário_textBox.Text != "" && senha_textBox.Text != "")
					{
						if (configBD_Apl.Conectar(bd))
							bd_comboBox.DataSource = configBD_Apl.pegaBDs();
						else
						{
							MessageBox.Show("Erro ao logar com autenticação SQL, usuário e senhas incorretos.\n\n" + configBD_Apl.erro,
										"Erro",
										  MessageBoxButtons.OK,
										 MessageBoxIcon.Error);
							Limpa();
						}
					}
					else
					{
						MessageBox.Show("Informe um usuário e senha para autenticação SQL!",
								"Atenção!",
								MessageBoxButtons.OK,
								MessageBoxIcon.Exclamation);
						Limpa();
					}
				}
			}
			else
			{
				Limpa();
				Bd_comboBoxEnter(sender, e);
			}
			this.Cursor = Cursors.Default;		
		}

        private void FormConfigBD_FormClosed(object sender, FormClosedEventArgs e)
        {
			Application.Exit();
        }

        private void autenticação_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			Limpa();
        }

        private void atualizarServidores_button_Click(object sender, EventArgs e)
        {
			Limpa();
			AtualizarServidores();
		}

        private void servidor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			Limpa();
		}

        private void cancelarButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void testaBd_button_Click(object sender, EventArgs e)
        {
			PreencheDados();
			if (bd.Bd != "")
			{
				if (!configBD_Apl.Conectar(bd))
				{
					MessageBox.Show("Erro ao tentar conectar com o banco de dados.\n\n" + configBD_Apl.erro,
											"Erro",
											  MessageBoxButtons.OK,
											 MessageBoxIcon.Error);
				}
				else
				{
					connection = configBD_Apl.connection;
					//okButton_Click();
					MessageBox.Show("Conexão com banco de dados bem sucedida!",
											"Informação",
												MessageBoxButtons.OK,
												MessageBoxIcon.Information);
					okButton.Enabled = true;
				}
			}
			else
				MessageBox.Show("Informe um banco de dados para continuar.\n\n",
										"Informação",
										  MessageBoxButtons.OK,
										 MessageBoxIcon.Information);
		}

		private void okButton_Click(object sender, EventArgs e)
        {
			chavesWin_Dom.Servidor = bd.Servidor;
			chavesWin_Dom.Instancia = bd.Instância;
			chavesWin_Dom.Autenticacao = bd.Autenticação;
			chavesWin_Dom.Usuario = bd.Usuário;
			chavesWin_Dom.Senha = bd.Senha;
			chavesWin_Dom.Bd = bd.Bd;
			chavesWin_Dom.Serial = "";

			if (chavesWin_Apl.CriarChaves(chavesWin_Dom))
				okButton_Click();
			else
				MessageBox.Show("Erro ao registrar o sistema. Entre em contato com o suporte a clientes, para mais informações acesse o Sobre do sistema.\n\n" + chavesWin_Apl.erro,
										"Informação",
										  MessageBoxButtons.OK,
										 MessageBoxIcon.Error);
		}
        
        void Bd_groupBoxEnter(object sender, EventArgs e)
        {
			if (!erro)
				this.Hide();
			else
			{

			}
		}

        private void FormConfigBD_Load(object sender, EventArgs e)
        {
			
		}
    }
}
