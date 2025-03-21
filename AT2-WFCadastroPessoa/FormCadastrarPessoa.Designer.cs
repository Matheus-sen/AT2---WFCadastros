namespace AT2_WFCadastroPessoa
{
    partial class FormCadastrarPessoa
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
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            mtbCpf = new MaskedTextBox();
            lblCpf = new Label();
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mtbDddTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            chkPossuiFilhos = new CheckBox();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(90, 23);
            txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 14);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Codigo :";
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(140, 32);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(119, 23);
            mtbCpf.TabIndex = 0;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(140, 14);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(37, 15);
            lblCpf.TabIndex = 5;
            lblCpf.Text = "CPF : ";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(12, 78);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(102, 15);
            lblNomeCompleto.TabIndex = 6;
            lblNomeCompleto.Text = "Nome Completo :";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(12, 97);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(247, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email :";
            // 
            // mtbDddTelefone
            // 
            mtbDddTelefone.Location = new Point(12, 218);
            mtbDddTelefone.Mask = "(00)00000-0000";
            mtbDddTelefone.Name = "mtbDddTelefone";
            mtbDddTelefone.Size = new Size(100, 23);
            mtbDddTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(12, 200);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(86, 15);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "DDD/Telefone :";
            // 
            // chkPossuiFilhos
            // 
            chkPossuiFilhos.AutoSize = true;
            chkPossuiFilhos.Location = new Point(12, 279);
            chkPossuiFilhos.Name = "chkPossuiFilhos";
            chkPossuiFilhos.Size = new Size(99, 19);
            chkPossuiFilhos.TabIndex = 5;
            chkPossuiFilhos.Text = "Possui Filhos?";
            chkPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(140, 200);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(119, 118);
            gbxTipoTelefone.TabIndex = 4;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo de Telefone :";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(12, 93);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(12, 56);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(12, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(171, 342);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(37, 342);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadastrarPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 388);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(chkPossuiFilhos);
            Controls.Add(lblTelefone);
            Controls.Add(mtbDddTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Controls.Add(lblCpf);
            Controls.Add(mtbCpf);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarPessoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Pessoa ";
            Load += FormCadastrarPessoa_Load;
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private MaskedTextBox mtbCpf;
        private Label lblCpf;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private Label lblEmail;
        private MaskedTextBox mtbDddTelefone;
        private Label lblTelefone;
        private CheckBox chkPossuiFilhos;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private Button btnCadastrar;
        private Button btnVoltar;
    }
}