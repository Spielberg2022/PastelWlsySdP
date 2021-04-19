
namespace PastelWlsySdP.Apresentacao
{
    partial class FormLocalizarUsuario
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
            this.localizarTabControl = new System.Windows.Forms.TabControl();
            this.codigoTabPage = new System.Windows.Forms.TabPage();
            this.codigoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTabPage = new System.Windows.Forms.TabPage();
            this.nomeDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.identificadorTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.localizarTabControl.SuspendLayout();
            this.codigoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).BeginInit();
            this.nomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).BeginInit();
            this.identificadorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // localizarTabControl
            // 
            this.localizarTabControl.Controls.Add(this.codigoTabPage);
            this.localizarTabControl.Controls.Add(this.nomeTabPage);
            this.localizarTabControl.Controls.Add(this.identificadorTabPage);
            this.localizarTabControl.Location = new System.Drawing.Point(12, 12);
            this.localizarTabControl.Name = "localizarTabControl";
            this.localizarTabControl.SelectedIndex = 0;
            this.localizarTabControl.Size = new System.Drawing.Size(465, 164);
            this.localizarTabControl.TabIndex = 0;
            // 
            // codigoTabPage
            // 
            this.codigoTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.codigoTabPage.Controls.Add(this.codigoDataGridView);
            this.codigoTabPage.Controls.Add(this.codigoTextBox);
            this.codigoTabPage.Location = new System.Drawing.Point(4, 22);
            this.codigoTabPage.Name = "codigoTabPage";
            this.codigoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.codigoTabPage.Size = new System.Drawing.Size(457, 138);
            this.codigoTabPage.TabIndex = 0;
            this.codigoTabPage.Text = "Código";
            // 
            // codigoDataGridView
            // 
            this.codigoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codigoDataGridView.Location = new System.Drawing.Point(6, 29);
            this.codigoDataGridView.Name = "codigoDataGridView";
            this.codigoDataGridView.Size = new System.Drawing.Size(445, 106);
            this.codigoDataGridView.TabIndex = 1;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(6, 3);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(445, 20);
            this.codigoTextBox.TabIndex = 0;
            this.codigoTextBox.Leave += new System.EventHandler(this.codigoTextBox_Leave);
            // 
            // nomeTabPage
            // 
            this.nomeTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.nomeTabPage.Controls.Add(this.nomeDataGridView);
            this.nomeTabPage.Controls.Add(this.nomeTextBox);
            this.nomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.nomeTabPage.Name = "nomeTabPage";
            this.nomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nomeTabPage.Size = new System.Drawing.Size(457, 138);
            this.nomeTabPage.TabIndex = 1;
            this.nomeTabPage.Text = "Nome";
            // 
            // nomeDataGridView
            // 
            this.nomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomeDataGridView.Location = new System.Drawing.Point(6, 30);
            this.nomeDataGridView.Name = "nomeDataGridView";
            this.nomeDataGridView.Size = new System.Drawing.Size(445, 105);
            this.nomeDataGridView.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(6, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(445, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // exibirButton
            // 
            this.exibirButton.Location = new System.Drawing.Point(483, 82);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(64, 64);
            this.exibirButton.TabIndex = 2;
            this.exibirButton.Text = "&Exibir";
            this.exibirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exibirButton.UseVisualStyleBackColor = true;
            // 
            // localizarButton
            // 
            this.localizarButton.Location = new System.Drawing.Point(483, 12);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(64, 64);
            this.localizarButton.TabIndex = 1;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarButton.UseVisualStyleBackColor = true;
            this.localizarButton.Click += new System.EventHandler(this.localizarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.Location = new System.Drawing.Point(484, 153);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(63, 23);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // sqlConnection
            // 
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // identificadorTabPage
            // 
            this.identificadorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.identificadorTabPage.Controls.Add(this.dataGridView1);
            this.identificadorTabPage.Controls.Add(this.textBox1);
            this.identificadorTabPage.Location = new System.Drawing.Point(4, 22);
            this.identificadorTabPage.Name = "identificadorTabPage";
            this.identificadorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.identificadorTabPage.Size = new System.Drawing.Size(457, 138);
            this.identificadorTabPage.TabIndex = 2;
            this.identificadorTabPage.Text = "Identificador";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 106);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 20);
            this.textBox1.TabIndex = 2;
            // 
            // FormLocalizarUsuario
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(553, 186);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.localizarTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLocalizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.localizarTabControl.ResumeLayout(false);
            this.codigoTabPage.ResumeLayout(false);
            this.codigoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).EndInit();
            this.nomeTabPage.ResumeLayout(false);
            this.nomeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).EndInit();
            this.identificadorTabPage.ResumeLayout(false);
            this.identificadorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl localizarTabControl;
        private System.Windows.Forms.TabPage codigoTabPage;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TabPage nomeTabPage;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.DataGridView codigoDataGridView;
        private System.Windows.Forms.DataGridView nomeDataGridView;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button cancelarButton;
        public System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Windows.Forms.TabPage identificadorTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}