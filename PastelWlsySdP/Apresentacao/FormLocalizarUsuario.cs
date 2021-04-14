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
        string varLoc = "";

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
                        usuario_Dom.Usuarios = usuario_Apl.LocCod(usuario_Dom.Codigo);
                        codigoDataGridView.DataSource = usuario_Dom.Usuarios;
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
    }
}
