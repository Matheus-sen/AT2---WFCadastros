namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(42, 43);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite o Login...";
            txtLogin.Size = new Size(119, 23);
            txtLogin.TabIndex = 0;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(42, 106);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite a Senha...";
            txtSenha.Size = new Size(119, 23);
            txtSenha.TabIndex = 1;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(86, 165);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            btnLogar.KeyDown += btnLogar_KeyDown;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 217);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnLogar;
    }
}
