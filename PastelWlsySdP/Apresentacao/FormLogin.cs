using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PastelWlsySdP.Aplicacao;

namespace PastelWlsySdP.Apresentacao
{
    public partial class FormLogin : Form
    {
        ClassUsuario_Apl usuario_Apl = new ClassUsuario_Apl();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            identificadorTextBox.Clear();
            senhaMaskedTextBox.Clear();
            identificadorTextBox.Focus();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            usuario_Apl.sqlConnection = sqlConnection;

            if(!usuario_Apl.Login(identificadorTextBox.Text.Trim(), senhaMaskedTextBox.Text.Trim()))
            {
                MessageBox.Show("Digite um usuário e senha válidos!",
                    "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                identificadorTextBox.Clear();
                senhaMaskedTextBox.Clear();
                identificadorTextBox.Focus();
            }
            else
            {
                MDIParent mDIParent = new MDIParent();
                mDIParent.sqlConnection = sqlConnection;
                mDIParent.telasUsuario = usuario_Apl.telasUsuario;
                mDIParent.Show();
                this.Hide();
            }
        }
    }
}
