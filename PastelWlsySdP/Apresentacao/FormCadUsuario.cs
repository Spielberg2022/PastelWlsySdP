using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web;

using PastelWlsySdP.Dominio;
using PastelWlsySdP.Aplicacao;

namespace PastelWlsySdP.Apresentacao
{
    public partial class FormCadUsuario : Form
    {
        public bool primeiroAcesso = false;
        private ClassCEP_Apl codigoPostal = new ClassCEP_Apl();
        private ClassUsuario_Apl usuario_Apl = new ClassUsuario_Apl();
        private ClassUsuario_Dom usuario_Dom = new ClassUsuario_Dom();

        public FormCadUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void FormCadUsuario_Load(object sender, EventArgs e)
        {
            if (primeiroAcesso)
            {
                loginLabel.Text = "Cadastro do Administrador GERAL";
                nomeTextBox.Enabled = true;
                identificadorTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
                salvarButton.Enabled = true;

                nomeTextBox.Text = "Administrador GERAL";
                identificadorTextBox.Text = "oportunidades@smn.com.br";
                senhaTextBox.Text = "teste123";
            }
        }

        private void usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if(editarButton.Text == "&Editar")
            {
                editarButton.Text = "&Cancelar";
                localizarButton.Enabled = false;
                imprimirButton.Enabled = false;
                novoButton.Enabled = false;
                salvarButton.Enabled = true;
                nomeTextBox.Enabled = true;
                identificadorTextBox.Enabled = true;
                situacaoComboBox.Enabled = true;
                autenticacaoCheckBox.Enabled = true;
                if (altSenhaCheckBox.Checked)
                {
                    senhaTextBox.Enabled = true;
                    senhaTextBox.Clear();
                    senhaTextBox.Focus();
                }
                else
                    nomeTextBox.Focus();               
            }
            else
            {
                editarButton.Text = "&Editar";
                localizarButton.Enabled = true;
                imprimirButton.Enabled = true;
                novoButton.Enabled = true;
                salvarButton.Enabled = false;
                nomeTextBox.Enabled = false;
                identificadorTextBox.Enabled = false;
                situacaoComboBox.Enabled = false;
                autenticacaoCheckBox.Enabled = false;
                altSenhaCheckBox.Checked = false;
                senhaTextBox.Enabled = false;
            }
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {

        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            usuario_Apl.sqlConnection = sqlConnection;
            if(!primeiroAcesso)
            {
                PreencheDadosUsuario();
                //Deixar essa opção para o final, depois de confirmado o salvamento
                nomeTextBox.Enabled = false;
                identificadorTextBox.Enabled = false;
                senhaTextBox.Enabled = false;
                situacaoComboBox.Enabled = false;
                autenticacaoCheckBox.Enabled = false;
                codigoLabel1.Text = "";
            }
            else
            {
                PreencheDadosUsuario();
                if(!usuario_Apl.InserirAdmGeral(usuario_Dom))
                    MessageBox.Show("Problemas ao inserir usuário!\n" + usuario_Apl.erro,
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                    MessageBox.Show("Usuário inserido com sucesso!",
                        "Informação:",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void PreencheDadosUsuario()
        {
            usuario_Dom = new ClassUsuario_Dom();
            usuario_Dom.Nome = nomeTextBox.Text;
            if (dt_nascimentoDateTimePicker.Value.Date < DateTime.Today)
                usuario_Dom.Dt_nascimento = dt_nascimentoDateTimePicker.Value.Date;
            else
                usuario_Dom.Dt_nascimento = DateTime.MinValue;
            this.Hide();
            usuario_Dom.Tel = telMaskedTextBox.Text;
            usuario_Dom.Cel = celMaskedTextBox.Text;
            usuario_Dom.Email = emailTextBox.Text;
            usuario_Dom.Cep = cepMaskedTextBox.Text;
            usuario_Dom.Logradouro = logradouroTextBox.Text;
            usuario_Dom.Bairro = bairroTextBox.Text;
            usuario_Dom.Cidade = cidadeTextBox.Text;
            usuario_Dom.Uf = ufComboBox.Text;
            usuario_Dom.Identificador = identificadorTextBox.Text;
            usuario_Dom.Senha = senhaTextBox.Text;
            //tipo
            //situação
            //foto
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            FormLocalizarUsuario formLocalizar = new FormLocalizarUsuario();
            formLocalizar.sqlConnection = sqlConnection;
            formLocalizar.ShowDialog();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            if(novoButton.Text == "&Novo")
            {
                novoButton.Text = "&Cancelar";
                localizarButton.Enabled = false;
                imprimirButton.Enabled = false;
                editarButton.Enabled = false;
                altSenhaCheckBox.Enabled = false;
                salvarButton.Enabled = true;

                codigoLabel1.Text = "NOVO CÓDIGO";
                nomeTextBox.Clear();
                dt_nascimentoDateTimePicker.Value = DateTime.Now;
                telMaskedTextBox.Clear();
                celMaskedTextBox.Clear();
                emailTextBox.Clear();
                cepMaskedTextBox.Clear();
                logradouroTextBox.Clear();
                bairroTextBox.Clear();
                cidadeTextBox.Clear();
                ufComboBox.ResetText();
                identificadorTextBox.Clear();
                senhaTextBox.Clear();
                tipoComboBox.ResetText();
                situacaoComboBox.Text = "";
                autenticacaoCheckBox.Checked = false;
                fotoPictureBox.Image = null;

                nomeTextBox.Enabled = true;
                dt_nascimentoDateTimePicker.Enabled = true;
                telMaskedTextBox.Enabled = true;
                celMaskedTextBox.Enabled = true;
                emailTextBox.Enabled = true;
                cepMaskedTextBox.Enabled = true;
                logradouroTextBox.Enabled = true;
                bairroTextBox.Enabled = true;
                cidadeTextBox.Enabled = true;
                ufComboBox.Enabled = true;
                identificadorTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
                altSenhaCheckBox.Enabled = false;
                tipoComboBox.Enabled = true;
                situacaoComboBox.Enabled = true;
                nomeTextBox.Focus();
            }
            else
            {
                novoButton.Text = "&Novo";
                localizarButton.Enabled = true;
                imprimirButton.Enabled = true;
                editarButton.Enabled = false;
                altSenhaCheckBox.Enabled = true;
                salvarButton.Enabled = false;

                codigoLabel1.Text = "";
                nomeTextBox.Clear();
                dt_nascimentoDateTimePicker.Value = DateTime.Now;
                telMaskedTextBox.Clear();
                celMaskedTextBox.Clear();
                emailTextBox.Clear();
                cepMaskedTextBox.Clear();
                logradouroTextBox.Clear();
                bairroTextBox.Clear();
                cidadeTextBox.Clear();
                ufComboBox.ResetText();
                identificadorTextBox.Clear();
                senhaTextBox.Clear();
                tipoComboBox.ResetText();
                situacaoComboBox.Text = "";
                autenticacaoCheckBox.Checked = false;
                fotoPictureBox.Image = null;

                nomeTextBox.Enabled = false;
                dt_nascimentoDateTimePicker.Enabled = false;
                telMaskedTextBox.Enabled = false;
                celMaskedTextBox.Enabled = false;
                emailTextBox.Enabled = false;
                cepMaskedTextBox.Enabled = false;
                logradouroTextBox.Enabled = false;
                bairroTextBox.Enabled = false;
                cidadeTextBox.Enabled = false;
                ufComboBox.Enabled = false;
                identificadorTextBox.Enabled = false;
                senhaTextBox.Enabled = false;
                altSenhaCheckBox.Enabled = false;
                tipoComboBox.Enabled = false;
                situacaoComboBox.Enabled = false;
            }
            
        }

        private void imprimirButton_Click_1(object sender, EventArgs e)
        {
            //FormImp formImp = new FormImp();
            //formImp.ShowDialog();
        }

        private void cepMaskedTextBox_Leave(object sender, EventArgs e)
        {
            codigoPostal = new ClassCEP_Apl();
            codigoPostal.BuscaCEP(cepMaskedTextBox.Text);
            logradouroTextBox.Text = codigoPostal.cep_Dom.Logradouro;
            bairroTextBox.Text = codigoPostal.cep_Dom.Bairro;
            cidadeTextBox.Text = codigoPostal.cep_Dom.Localidade;
            ufComboBox.Text = codigoPostal.cep_Dom.Uf;
        }

        private void LocalizarCEP()
        {
            
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
    }
}
