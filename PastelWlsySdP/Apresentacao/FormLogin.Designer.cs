
namespace PastelWlsySdP.Apresentacao
{
    partial class FormLogin
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.identificadorLabel = new System.Windows.Forms.Label();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.senhaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.entrarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.cancelarButton);
            this.loginGroupBox.Controls.Add(this.limparButton);
            this.loginGroupBox.Controls.Add(this.entrarButton);
            this.loginGroupBox.Controls.Add(this.senhaLabel);
            this.loginGroupBox.Controls.Add(this.senhaMaskedTextBox);
            this.loginGroupBox.Controls.Add(this.identificadorTextBox);
            this.loginGroupBox.Controls.Add(this.identificadorLabel);
            this.loginGroupBox.Controls.Add(this.loginLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(12, 10);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(407, 227);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginLabel.Location = new System.Drawing.Point(157, 35);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(85, 31);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // identificadorLabel
            // 
            this.identificadorLabel.AutoSize = true;
            this.identificadorLabel.Location = new System.Drawing.Point(52, 108);
            this.identificadorLabel.Name = "identificadorLabel";
            this.identificadorLabel.Size = new System.Drawing.Size(68, 13);
            this.identificadorLabel.TabIndex = 1;
            this.identificadorLabel.Text = "Identificador:";
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.Location = new System.Drawing.Point(126, 105);
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(220, 20);
            this.identificadorTextBox.TabIndex = 2;
            // 
            // senhaMaskedTextBox
            // 
            this.senhaMaskedTextBox.Location = new System.Drawing.Point(126, 131);
            this.senhaMaskedTextBox.Name = "senhaMaskedTextBox";
            this.senhaMaskedTextBox.Size = new System.Drawing.Size(220, 20);
            this.senhaMaskedTextBox.TabIndex = 4;
            this.senhaMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(52, 134);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(41, 13);
            this.senhaLabel.TabIndex = 3;
            this.senhaLabel.Text = "Senha:";
            // 
            // entrarButton
            // 
            this.entrarButton.Location = new System.Drawing.Point(82, 178);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(75, 23);
            this.entrarButton.TabIndex = 5;
            this.entrarButton.Text = "&Entrar";
            this.entrarButton.UseVisualStyleBackColor = true;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.limparButton.Location = new System.Drawing.Point(163, 178);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 6;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(244, 178);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // sqlConnection
            // 
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.entrarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.limparButton;
            this.ClientSize = new System.Drawing.Size(431, 251);
            this.Controls.Add(this.loginGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(431, 251);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.MaskedTextBox senhaMaskedTextBox;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.Label identificadorLabel;
        private System.Windows.Forms.Label loginLabel;
        public System.Data.SqlClient.SqlConnection sqlConnection;
    }
}