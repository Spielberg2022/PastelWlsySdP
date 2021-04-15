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

        public FormCadUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.usuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.gestorWslyDataSet);

        }

        private void FormCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'usuariosDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.usuariosTableAdapter.Fill(this.usuariosDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'usuariosDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.usuariosTableAdapter.Fill(this.usuariosDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'gestorWslyDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            //this.usuarioTableAdapter.Fill(this.gestorWslyDataSet.Usuario);
            // TODO: esta linha de código carrega dados na tabela 'gestorWslyDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            //this.usuarioTableAdapter.Fill(this.gestorWslyDataSet.Usuario);

            if (primeiroAcesso)
            {
                loginLabel.Text = "Cadastro do Administrador GERAL";
                altSenhaCheckBox.Enabled = false;
                situacaoComboBox.Enabled = false;
                autenticacaoCheckBox.Enabled = false;
                tipoComboBox.Enabled = false;
                localizarButton.Enabled = false;
                novoButton.Enabled = false;
                editarButton.Enabled = false;
                imprimirButton.Enabled = false;
                nomeTextBox.Enabled = true;
                identificadorTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
                salvarButton.Enabled = true;


            }
        }

        private void usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            //this.usuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.gestorWslyDataSet);

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
            if(!primeiroAcesso)
            {
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
                this.Hide();
            }
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
                identificadorTextBox.Clear();
                senhaTextBox.Clear();
                situacaoComboBox.Text = "";
                autenticacaoCheckBox.Checked = false;
                nomeTextBox.Enabled = true;
                identificadorTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
                situacaoComboBox.Enabled = true;
                altSenhaCheckBox.Enabled = true;
                nomeTextBox.Focus();
            }
            else
            {
                novoButton.Text = "&Novo";
                localizarButton.Enabled = true;
                imprimirButton.Enabled = true;
                editarButton.Enabled = true;
                altSenhaCheckBox.Enabled = true;
                salvarButton.Enabled = false;
                codigoLabel1.Text = "";
                nomeTextBox.Clear();
                identificadorTextBox.Clear();
                senhaTextBox.Clear();
                situacaoComboBox.Text = "";
                autenticacaoCheckBox.Checked = true;
                nomeTextBox.Enabled = false;
                identificadorTextBox.Enabled = false;
                senhaTextBox.Enabled = false;
                situacaoComboBox.Enabled = false;
                altSenhaCheckBox.Enabled = false;
            }
            
        }

        private void imprimirButton_Click_1(object sender, EventArgs e)
        {
            //FormImp formImp = new FormImp();
            //formImp.ShowDialog();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.usuariosBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.usuariosDataSet);

        }

        private void usuariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.usuariosBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.usuariosDataSet);

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
    }
}
