using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PastelWlsySdP.Dominio;
using PastelWlsySdP.Aplicacao;

namespace PastelWlsySdP.Apresentacao
{
    public partial class FormLocalizarUsuario : Form
    {
        
        ClassUsuario_Dom usuario_Dom = new ClassUsuario_Dom();
        ClassUsuario_Apl usuario_Apl = new ClassUsuario_Apl();
        public string varLoc = "";
        public DataTable selecao = new DataTable();

        public FormLocalizarUsuario()
        {
            InitializeComponent();
        }

        private void codigoTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "codigo";
            
            if (codigoTextBox.Text != null && codigoTextBox.Text != "")
            {
                usuario_Dom.Codigo = int.Parse(codigoTextBox.Text);
                localizarButton_Click(sender, e);
            }                 
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                usuario_Apl.sqlConnection = sqlConnection;
                switch (varLoc)
                {
                    case "codigo":
                        codigoDataGridView.DataSource = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), varLoc);
                        break;
                    case "identificador":
                        identificadorDataGridView.DataSource = usuario_Apl.Localizar(usuario_Dom.Identificador, varLoc);
                        break;
                    case "nome":
                        nomeDataGridView.DataSource = usuario_Apl.Localizar(usuario_Dom.Nome, varLoc);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro inexperado, entrar em contato com o suporte. Para mais informações acesse o Sobre do sistema.\n\n" + error.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {

            }            
        }

        private void nomeTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "nome";

            if (nomeTextBox.Text != null && nomeTextBox.Text != "")
            {
                usuario_Dom.Nome = nomeTextBox.Text.Trim();
                localizarButton_Click(sender, e);
            }
        }

        private void identificadorTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "identificador";

            if (identificadorTextBox.Text != null && identificadorTextBox.Text != "")
            {
                usuario_Dom.Identificador = identificadorTextBox.Text.Trim();
                localizarButton_Click(sender, e);
            }
        }

        private void exibirButton_Click(object sender, EventArgs e)
        {
            selecao = new DataTable();

            try
            {
                switch (varLoc)
                {
                    case "codigo":
                        usuario_Dom.Codigo = int.Parse(codigoDataGridView.CurrentRow.Cells[0].Value.ToString());
                        selecao = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), "codigo");
                        break;
                    case "identificador":
                        usuario_Dom.Codigo = int.Parse(identificadorDataGridView.CurrentRow.Cells[0].Value.ToString());
                        selecao = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), "codigo");
                        break;
                    case "nome":
                        usuario_Dom.Codigo = int.Parse(nomeDataGridView.CurrentRow.Cells[0].Value.ToString());
                        selecao = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), "codigo");
                        break;
                    default:
                        break;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Erro inexperado, entrar em contato com o suporte. Para mais informações acesse o Sobre do sistema.\n\n" + error.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Hide();
            }
        }
    }
}
