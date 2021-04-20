using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private Bitmap bmp;
        private byte[] foto;
        

        public FormCadUsuario()
        {
            InitializeComponent();
        }

        private void FormCadUsuario_Load(object sender, EventArgs e)
        {
            tipoComboBox.Enabled = true;
            usuario_Apl.sqlConnection = sqlConnection;
            tipoComboBox.Items.Clear();
            tipoComboBox.DataSource = usuario_Apl.ListarTipos();
            tipoComboBox.DisplayMember = "descricao";
            tipoComboBox.ValueMember = "codigo";

            if (primeiroAcesso)
            {
                loginLabel.Text = "Cadastro do Administrador GERAL";
                nomeTextBox.Enabled = true;
                identificadorTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
                tipoComboBox.Enabled = false;
                salvarButton.Enabled = true;

                localizarButton.Enabled = false;
                editarButton.Enabled = false;
                imprimirButton.Enabled = false;
                novoButton.Enabled = false;

                nomeTextBox.Text = "Administrador GERAL";
                identificadorTextBox.Text = "oportunidades@smn.com.br";
                senhaTextBox.Text = "teste123";
            }
            else
            {
                TelaInicial();
            }
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
                if (altSenhaCheckBox.Checked)
                {
                    senhaTextBox.Enabled = true;
                    senhaTextBox.Clear();
                    senhaTextBox.Focus();
                }
                tipoComboBox.Enabled = true;              
            }
            else
            {
                editarButton.Text = "&Editar";
                localizarButton.Enabled = true;
                imprimirButton.Enabled = true;
                novoButton.Enabled = true;
                salvarButton.Enabled = false;

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
                altSenhaCheckBox.Checked = false;
                if (!altSenhaCheckBox.Checked)
                    senhaTextBox.Enabled = false;
                tipoComboBox.Enabled = true;
            }
            nomeTextBox.Focus();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            usuario_Apl.sqlConnection = sqlConnection;
            if (!primeiroAcesso)
            {
                PreencheDadosUsuario();
                
                if(tipoComboBox.SelectedValue.ToString() != "")
                {
                    usuario_Dom.Tipo = int.Parse(tipoComboBox.SelectedValue.ToString());
                    if (usuario_Dom.Nome != "" && usuario_Dom.Identificador != "" && usuario_Dom.Senha != "")
                    {
                        if (!usuario_Apl.InserirUsuario(usuario_Dom))
                            MessageBox.Show("Problemas ao inserir usuário!\n" + usuario_Apl.erro,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        else
                        {
                            MessageBox.Show("Usuário inserido com sucesso!",
                                "Informação:",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            TelaInicial();
                        }
                    }
                    else
                        MessageBox.Show("Os campos obrigatórios não foram preenchidos!",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Os tipos de usuário não estão cadastrados!",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

            }
            else
            {
                PreencheDadosUsuario();
                if (!usuario_Apl.InserirAdmGeral(usuario_Dom))
                    MessageBox.Show("Problemas ao inserir usuário!\n" + usuario_Apl.erro,
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Usuário inserido com sucesso!",
                        "Informação:",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                }
                this.Hide();
            }
        }

        private void TelaInicial()
        {
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
            tipoComboBox.Enabled = false;

            localizarButton.Enabled = true;
            novoButton.Enabled = true;
            editarButton.Enabled = false;
            salvarButton.Enabled = false;
            imprimirButton.Enabled = true;
        }

        private void PreencheDadosUsuario()
        {
            usuario_Dom = new ClassUsuario_Dom();
            usuario_Dom.Nome = nomeTextBox.Text.Trim();
            if (dt_nascimentoDateTimePicker.Value.Date < DateTime.Today)
                usuario_Dom.Dt_nascimento = dt_nascimentoDateTimePicker.Value.Date;
            else
                usuario_Dom.Dt_nascimento = DateTime.MinValue;
            usuario_Dom.Tel = telMaskedTextBox.Text.Trim();
            usuario_Dom.Cel = celMaskedTextBox.Text.Trim();
            usuario_Dom.Email = emailTextBox.Text.Trim();
            usuario_Dom.Cep = cepMaskedTextBox.Text.Trim();
            usuario_Dom.Logradouro = logradouroTextBox.Text.Trim();
            usuario_Dom.Bairro = bairroTextBox.Text.Trim();
            usuario_Dom.Cidade = cidadeTextBox.Text.Trim();
            usuario_Dom.Uf = ufComboBox.Text.Trim();
            usuario_Dom.Identificador = identificadorTextBox.Text.Trim();
            usuario_Dom.Senha = senhaTextBox.Text.Trim();
            
            usuario_Dom.Foto = foto;
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormLocalizarUsuario formLocalizar = new FormLocalizarUsuario();
                formLocalizar.sqlConnection = sqlConnection;
                formLocalizar.ShowDialog();
                editarButton.Enabled = true;
                codigoLabel1.Text = formLocalizar.selecao.Rows[0][0].ToString();
                nomeTextBox.Text = formLocalizar.selecao.Rows[0][1].ToString();
                identificadorTextBox.Text = formLocalizar.selecao.Rows[0][2].ToString();
                senhaTextBox.Text = formLocalizar.selecao.Rows[0][3].ToString();

                //usuario_Dom.Tipo = int.Parse(nomeDataGridView.CurrentRow.Cells[4].Value.ToString());
                if (formLocalizar.selecao.Rows[0][5].ToString() == "01/01/0001 00:00:00" || formLocalizar.selecao.Rows[0][5].ToString() == "")
                    dt_nascimentoDateTimePicker.Value = DateTime.Parse("01/01/1900 00:00:00");
                else
                    dt_nascimentoDateTimePicker.Value = DateTime.Parse(formLocalizar.selecao.Rows[0][5].ToString());
                telMaskedTextBox.Text = formLocalizar.selecao.Rows[0][6].ToString();
                celMaskedTextBox.Text = formLocalizar.selecao.Rows[0][7].ToString();
                emailTextBox.Text = formLocalizar.selecao.Rows[0][8].ToString();
                logradouroTextBox.Text = formLocalizar.selecao.Rows[0][9].ToString();
                bairroTextBox.Text = formLocalizar.selecao.Rows[0][10].ToString();
                cidadeTextBox.Text = formLocalizar.selecao.Rows[0][11].ToString();
                ufComboBox.Text = formLocalizar.selecao.Rows[0][12].ToString();
                cepMaskedTextBox.Text = formLocalizar.selecao.Rows[0][13].ToString();

                byte[] imagem;
                if (formLocalizar.selecao.Rows[0][14].ToString() != "")
                {
                    imagem = (byte[])(formLocalizar.selecao.Rows[0][14]);
                    MemoryStream memory = new MemoryStream(imagem);
                    fotoPictureBox.Image = Image.FromStream(memory);
                }
                else
                    fotoPictureBox.Image = null;
            }
            catch(Exception error)
            {

            }
            finally
            {

            }
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
                altSenhaCheckBox.Enabled = true;
                tipoComboBox.Enabled = true;
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
                altSenhaCheckBox.Enabled = true;
                tipoComboBox.Enabled = false;
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
            codigoPostal.cep_Dom.Cep = celMaskedTextBox.Text;
            logradouroTextBox.Text = codigoPostal.cep_Dom.Logradouro;
            bairroTextBox.Text = codigoPostal.cep_Dom.Bairro;
            cidadeTextBox.Text = codigoPostal.cep_Dom.Localidade;
            ufComboBox.Text = codigoPostal.cep_Dom.Uf;
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog.FileName;
                bmp = new Bitmap(nome);
                fotoPictureBox.Image = bmp;

                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Jpeg);
                foto = memory.ToArray();
            }
        }
    }
}
