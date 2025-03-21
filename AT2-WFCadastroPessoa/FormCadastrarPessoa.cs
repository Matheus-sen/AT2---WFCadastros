using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastrarPessoa : Form
    {
        public FormCadastrarPessoa()
        {
            InitializeComponent();
        }
        private void LimparFormulario()
        {
            mtbCpf.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            mtbDddTelefone.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string semMaskTelefone = mtbDddTelefone.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");

            if (string.IsNullOrEmpty(mtbCpf.Text))
            {
                Erro("Campo CPF não pode estar Vazio!");
                return;
            }
            ////Verifica 
            else if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                Erro("Campo Nome Completo não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo Email não pode estar Vazio!");
                return;
            }
            ////Verifica 
            else if (string.IsNullOrEmpty(semMaskTelefone))
            {
                Erro("Campo Telefone não pode estar Vazio!");
                return;
            }
            else
            {
                Pessoa p1 = new Pessoa();
                p1.Codigo = Convert.ToInt32(txtCodigo.Text);
                p1.Cpf = mtbCpf.Text;
                p1.NomeCompleto = txtNomeCompleto.Text;
                p1.Email = txtEmail.Text;
                p1.DddTelefone = mtbDddTelefone.Text;

                if (rdbPessoal.Checked)
                {
                    p1.TipoTelefone = "Pessoal";
                }
                else if (rdbComercial.Checked)
                {
                    p1.TipoTelefone = "Comercial";
                }
                else if (rdbRecado.Checked)
                {
                    p1.TipoTelefone = "Recado";
                }
                else
                {
                    Erro("Tipo telefone não definido!");
                    return;
                }

                if (chkPossuiFilhos.CheckState == CheckState.Checked)
                {
                    p1.PossuiFilhos = true;
                }
                else if (chkPossuiFilhos.CheckState == CheckState.Unchecked)
                {
                    p1.PossuiFilhos = false;
                }
                else
                {
                    Erro("Faltou marcar se tem Filhos!");
                    return;
                }

                Pessoa.ListaPessoas.Add(p1);

                MessageBox.Show("Cadastro realizado com sucesso!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigo.Text = (Pessoa.ListaPessoas.Count + 1).ToString();

                LimparFormulario();

            }

        }

        private void FormCadastrarPessoa_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = (Pessoa.ListaPessoas.Count + 1).ToString();
            txtCodigo.Enabled = false;
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
