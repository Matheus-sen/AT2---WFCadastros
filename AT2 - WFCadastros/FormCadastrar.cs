using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2___WFCadastros
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNomeCategoria.Clear();
            txtDescricao.Clear();
            cbxStatus.SelectedIndex = -1;
            dtpDataCadastro.Value = DateTime.Now;
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Erro("Campo 'Código' não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtNomeCategoria.Text))
            {
                Erro("Campo 'Nome da Categoria' não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Erro("Campo 'Descrição' não pode estar Vazio!");
                return;
            }
            ////Verifica 
            else if (string.IsNullOrEmpty(cbxStatus.Text))
            {
                Erro("Campo 'Status' não pode estar Vazio!");
                return;
            }
            else
            {
                Sucesso("Categoria Cadastrada com sucesso!");

            }

            Categoria cat = new Categoria();
            cat.Codigo = Convert.ToInt32(txtCodigo.Text);
            cat.NomeCategoria = txtNomeCategoria.Text;
            cat.Descricao = txtDescricao.Text;
            cat.Status = cbxStatus.SelectedItem?.ToString();
            cat.DataCadastro = dtpDataCadastro.Text;

            Categoria.ListaCategorias.Add(cat);

            txtCodigo.Text = (Categoria.ListaCategorias.Count + 1).ToString();

            LimparFormulario();
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = (Categoria.ListaCategorias.Count + 1).ToString();
            txtCodigo.Enabled = false;
        }
    }
}
