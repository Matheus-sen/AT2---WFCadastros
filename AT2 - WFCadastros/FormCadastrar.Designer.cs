namespace AT2___WFCadastros
{
    partial class FormCadastrar
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNomeCategoria = new Label();
            txtNomeCategoria = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            cbxStatus = new ComboBox();
            lblStatus = new Label();
            dtpDataCadastro = new DateTimePicker();
            lblDataCadastro = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo :";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(90, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.Location = new Point(109, 9);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(116, 15);
            lblNomeCategoria.TabIndex = 2;
            lblNomeCategoria.Text = "Nome da Categoria :";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(109, 27);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(165, 23);
            txtNomeCategoria.TabIndex = 0;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 68);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(64, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição :";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 86);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(262, 86);
            txtDescricao.TabIndex = 1;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbxStatus.Location = new Point(12, 217);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(121, 23);
            cbxStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 199);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status :";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(154, 217);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(120, 23);
            dtpDataCadastro.TabIndex = 3;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(154, 199);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(103, 15);
            lblDataCadastro.TabIndex = 9;
            lblDataCadastro.Text = "Data de Cadastro :";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(199, 292);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 336);
            Controls.Add(btnCadastrar);
            Controls.Add(lblDataCadastro);
            Controls.Add(dtpDataCadastro);
            Controls.Add(lblStatus);
            Controls.Add(cbxStatus);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNomeCategoria);
            Controls.Add(lblNomeCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Categoria";
            Load += FormCadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNomeCategoria;
        private TextBox txtNomeCategoria;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private ComboBox cbxStatus;
        private Label lblStatus;
        private DateTimePicker dtpDataCadastro;
        private Label lblDataCadastro;
        private Button btnCadastrar;
    }
}