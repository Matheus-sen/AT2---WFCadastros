namespace AT2___WFCadastros
{
    partial class FormListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListar));
            dgvListaCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCategorias
            // 
            resources.ApplyResources(dgvListaCategorias, "dgvListaCategorias");
            dgvListaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCategorias.Name = "dgvListaCategorias";
            // 
            // FormListar
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvListaCategorias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListar";
            Load += FormListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCategorias;
    }
}