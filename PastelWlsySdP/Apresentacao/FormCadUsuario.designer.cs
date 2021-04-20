
namespace PastelWlsySdP.Apresentacao
{
    partial class FormCadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label identificadorLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label dt_nascimentoLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label celLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadUsuario));
            this.usuariosGroupBox = new System.Windows.Forms.GroupBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.celMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dt_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.altSenhaCheckBox = new System.Windows.Forms.CheckBox();
            this.codigoLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.editarButton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bstipo = new System.Windows.Forms.BindingSource(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            identificadorLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            dt_nascimentoLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            celLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.usuariosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstipo)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(12, 25);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = System.Drawing.Color.DarkRed;
            nomeLabel.Location = new System.Drawing.Point(12, 54);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // identificadorLabel
            // 
            identificadorLabel.AutoSize = true;
            identificadorLabel.ForeColor = System.Drawing.Color.DarkRed;
            identificadorLabel.Location = new System.Drawing.Point(54, 251);
            identificadorLabel.Name = "identificadorLabel";
            identificadorLabel.Size = new System.Drawing.Size(68, 13);
            identificadorLabel.TabIndex = 22;
            identificadorLabel.Text = "Identificador:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.ForeColor = System.Drawing.Color.DarkRed;
            senhaLabel.Location = new System.Drawing.Point(54, 277);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 24;
            senhaLabel.Text = "Senha:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.ForeColor = System.Drawing.Color.DarkRed;
            tipoLabel.Location = new System.Drawing.Point(54, 303);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 27;
            tipoLabel.Text = "Tipo:";
            // 
            // dt_nascimentoLabel
            // 
            dt_nascimentoLabel.AutoSize = true;
            dt_nascimentoLabel.Location = new System.Drawing.Point(12, 80);
            dt_nascimentoLabel.Name = "dt_nascimentoLabel";
            dt_nascimentoLabel.Size = new System.Drawing.Size(66, 13);
            dt_nascimentoLabel.TabIndex = 4;
            dt_nascimentoLabel.Text = "Nascimento:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(12, 106);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(52, 13);
            telLabel.TabIndex = 6;
            telLabel.Text = "Telefone:";
            // 
            // celLabel
            // 
            celLabel.AutoSize = true;
            celLabel.Location = new System.Drawing.Point(196, 106);
            celLabel.Name = "celLabel";
            celLabel.Size = new System.Drawing.Size(42, 13);
            celLabel.TabIndex = 8;
            celLabel.Text = "Celular:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 132);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "E-mail:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(196, 158);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(64, 13);
            logradouroLabel.TabIndex = 14;
            logradouroLabel.Text = "Logradouro:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(12, 183);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 16;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(319, 184);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 18;
            cidadeLabel.Text = "Cidade:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(12, 158);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 12;
            cepLabel.Text = "CEP:";
            // 
            // ufLabel
            // 
            ufLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(523, 183);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(24, 13);
            ufLabel.TabIndex = 20;
            ufLabel.Text = "UF:";
            // 
            // fotoLabel
            // 
            fotoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(470, 216);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 32;
            fotoLabel.Text = "Foto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.DarkRed;
            label1.Location = new System.Drawing.Point(6, 336);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(298, 13);
            label1.TabIndex = 34;
            label1.Text = "* Os campos em vermelho são de preenchimento obrigatórios!";
            // 
            // usuariosGroupBox
            // 
            this.usuariosGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuariosGroupBox.Controls.Add(label1);
            this.usuariosGroupBox.Controls.Add(fotoLabel);
            this.usuariosGroupBox.Controls.Add(this.fotoPictureBox);
            this.usuariosGroupBox.Controls.Add(ufLabel);
            this.usuariosGroupBox.Controls.Add(this.ufComboBox);
            this.usuariosGroupBox.Controls.Add(cepLabel);
            this.usuariosGroupBox.Controls.Add(this.cepMaskedTextBox);
            this.usuariosGroupBox.Controls.Add(cidadeLabel);
            this.usuariosGroupBox.Controls.Add(this.cidadeTextBox);
            this.usuariosGroupBox.Controls.Add(bairroLabel);
            this.usuariosGroupBox.Controls.Add(this.bairroTextBox);
            this.usuariosGroupBox.Controls.Add(logradouroLabel);
            this.usuariosGroupBox.Controls.Add(this.logradouroTextBox);
            this.usuariosGroupBox.Controls.Add(emailLabel);
            this.usuariosGroupBox.Controls.Add(this.emailTextBox);
            this.usuariosGroupBox.Controls.Add(celLabel);
            this.usuariosGroupBox.Controls.Add(this.celMaskedTextBox);
            this.usuariosGroupBox.Controls.Add(telLabel);
            this.usuariosGroupBox.Controls.Add(this.telMaskedTextBox);
            this.usuariosGroupBox.Controls.Add(dt_nascimentoLabel);
            this.usuariosGroupBox.Controls.Add(this.dt_nascimentoDateTimePicker);
            this.usuariosGroupBox.Controls.Add(tipoLabel);
            this.usuariosGroupBox.Controls.Add(this.tipoComboBox);
            this.usuariosGroupBox.Controls.Add(this.altSenhaCheckBox);
            this.usuariosGroupBox.Controls.Add(codigoLabel);
            this.usuariosGroupBox.Controls.Add(this.codigoLabel1);
            this.usuariosGroupBox.Controls.Add(nomeLabel);
            this.usuariosGroupBox.Controls.Add(this.nomeTextBox);
            this.usuariosGroupBox.Controls.Add(identificadorLabel);
            this.usuariosGroupBox.Controls.Add(this.identificadorTextBox);
            this.usuariosGroupBox.Controls.Add(senhaLabel);
            this.usuariosGroupBox.Controls.Add(this.senhaTextBox);
            this.usuariosGroupBox.Location = new System.Drawing.Point(143, 79);
            this.usuariosGroupBox.Name = "usuariosGroupBox";
            this.usuariosGroupBox.Size = new System.Drawing.Size(618, 357);
            this.usuariosGroupBox.TabIndex = 2;
            this.usuariosGroupBox.TabStop = false;
            this.usuariosGroupBox.Text = "Usuário:";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoPictureBox.Location = new System.Drawing.Point(504, 216);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(100, 133);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 33;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // ufComboBox
            // 
            this.ufComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ufComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ufComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ufComboBox.Enabled = false;
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.ufComboBox.Location = new System.Drawing.Point(548, 180);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(56, 21);
            this.ufComboBox.TabIndex = 21;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.Enabled = false;
            this.cepMaskedTextBox.Location = new System.Drawing.Point(90, 155);
            this.cepMaskedTextBox.Mask = "99,999-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepMaskedTextBox.TabIndex = 13;
            this.cepMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cepMaskedTextBox.Leave += new System.EventHandler(this.cepMaskedTextBox_Leave);
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadeTextBox.Enabled = false;
            this.cidadeTextBox.Location = new System.Drawing.Point(367, 181);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(147, 20);
            this.cidadeTextBox.TabIndex = 19;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Enabled = false;
            this.bairroTextBox.Location = new System.Drawing.Point(90, 181);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(219, 20);
            this.bairroTextBox.TabIndex = 17;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logradouroTextBox.Enabled = false;
            this.logradouroTextBox.Location = new System.Drawing.Point(266, 155);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(338, 20);
            this.logradouroTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(90, 129);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(514, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // celMaskedTextBox
            // 
            this.celMaskedTextBox.Enabled = false;
            this.celMaskedTextBox.Location = new System.Drawing.Point(244, 103);
            this.celMaskedTextBox.Mask = "(99) 9 9999-9999";
            this.celMaskedTextBox.Name = "celMaskedTextBox";
            this.celMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.celMaskedTextBox.TabIndex = 9;
            this.celMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // telMaskedTextBox
            // 
            this.telMaskedTextBox.Enabled = false;
            this.telMaskedTextBox.Location = new System.Drawing.Point(90, 103);
            this.telMaskedTextBox.Mask = "(99) 9999-9999";
            this.telMaskedTextBox.Name = "telMaskedTextBox";
            this.telMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telMaskedTextBox.TabIndex = 7;
            this.telMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dt_nascimentoDateTimePicker
            // 
            this.dt_nascimentoDateTimePicker.Enabled = false;
            this.dt_nascimentoDateTimePicker.Location = new System.Drawing.Point(90, 77);
            this.dt_nascimentoDateTimePicker.Name = "dt_nascimentoDateTimePicker";
            this.dt_nascimentoDateTimePicker.Size = new System.Drawing.Size(254, 20);
            this.dt_nascimentoDateTimePicker.TabIndex = 5;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipoComboBox.Enabled = false;
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(132, 300);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(230, 21);
            this.tipoComboBox.TabIndex = 28;
            // 
            // altSenhaCheckBox
            // 
            this.altSenhaCheckBox.AutoSize = true;
            this.altSenhaCheckBox.Enabled = false;
            this.altSenhaCheckBox.Location = new System.Drawing.Point(369, 277);
            this.altSenhaCheckBox.Name = "altSenhaCheckBox";
            this.altSenhaCheckBox.Size = new System.Drawing.Size(88, 17);
            this.altSenhaCheckBox.TabIndex = 26;
            this.altSenhaCheckBox.Text = "Alterar senha";
            this.altSenhaCheckBox.UseVisualStyleBackColor = true;
            // 
            // codigoLabel1
            // 
            this.codigoLabel1.Location = new System.Drawing.Point(90, 25);
            this.codigoLabel1.Name = "codigoLabel1";
            this.codigoLabel1.Size = new System.Drawing.Size(104, 23);
            this.codigoLabel1.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(90, 51);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(514, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.Enabled = false;
            this.identificadorTextBox.Location = new System.Drawing.Point(132, 248);
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(230, 20);
            this.identificadorTextBox.TabIndex = 23;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Enabled = false;
            this.senhaTextBox.Location = new System.Drawing.Point(132, 274);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(230, 20);
            this.senhaTextBox.TabIndex = 25;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginLabel.Location = new System.Drawing.Point(143, 22);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(317, 33);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Cadastro de Usuários";
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editarButton.Enabled = false;
            this.editarButton.Location = new System.Drawing.Point(767, 191);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(64, 23);
            this.editarButton.TabIndex = 4;
            this.editarButton.Text = "&Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimirButton.Location = new System.Drawing.Point(767, 290);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(64, 23);
            this.imprimirButton.TabIndex = 6;
            this.imprimirButton.Text = "&Imprimir";
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click_1);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.Location = new System.Drawing.Point(767, 162);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(64, 23);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "&Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // localizarButton
            // 
            this.localizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarButton.Location = new System.Drawing.Point(767, 92);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(64, 64);
            this.localizarButton.TabIndex = 2;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarButton.UseVisualStyleBackColor = true;
            this.localizarButton.Click += new System.EventHandler(this.localizarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.Enabled = false;
            this.salvarButton.Location = new System.Drawing.Point(767, 220);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(64, 64);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PastelWlsySdP.Properties.Resources.Cadastro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sqlConnection
            // 
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Abrir Imagem";
            this.openFileDialog.Filter = "Fotos JPG|*.jpg|Fotos JPEG|*.jpeg";
            // 
            // FormCadUsuario
            // 
            this.AcceptButton = this.localizarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 448);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.usuariosGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(859, 487);
            this.Name = "FormCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FormCadUsuario_Load);
            this.usuariosGroupBox.ResumeLayout(false);
            this.usuariosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox usuariosGroupBox;
        private System.Windows.Forms.Label codigoLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.CheckBox altSenhaCheckBox;
        public System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.DateTimePicker dt_nascimentoDateTimePicker;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox celMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telMaskedTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource bstipo;
    }
}