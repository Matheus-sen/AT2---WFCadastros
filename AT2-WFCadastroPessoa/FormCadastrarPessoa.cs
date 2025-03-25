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
        private void LimparFormulario() //Método para limpar o formulário, utilizado no meu caso no final do código.
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
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Método para indicar erro em determinado ponto que seja preciso. Puxando apenas pelo seu nome "Erro".
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string semMaskTelefone = mtbDddTelefone.Text //Tira a Máscara do preenchimento, não contando como string ou texto digitado pelo usuário, invalidando em caso de não digitar número algum no DDDTelefone.
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");

            //Verifica os campos vazios.
            if (string.IsNullOrEmpty(mtbCpf.Text))
            {
                Erro("Campo CPF não pode estar Vazio!");
                return;
            }

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

            else if (string.IsNullOrEmpty(semMaskTelefone))
            {
                Erro("Campo Telefone não pode estar Vazio!");
                return;
            }
            else
            {
                //Verifica se o CPF já foi cadastrado, percorrendo a lista com foreach.
                foreach (Pessoa p2 in Pessoa.ListaPessoas)
                {
                    if (mtbCpf.Text == p2.Cpf)
                    {
                        Erro("CPF já cadastrado!!");
                        mtbCpf.Clear();
                        return;
                    }
                }

                Pessoa p1 = new Pessoa(); // cadastra uma nova pessoa, desde que a condição anterior (foreach) não seja verdadeira.
                p1.Codigo = Convert.ToInt32(txtCodigo.Text);
                p1.Cpf = mtbCpf.Text;
                p1.NomeCompleto = txtNomeCompleto.Text;
                p1.Email = txtEmail.Text;
                p1.Ddd = semMaskTelefone.Substring(0, 2); //Puxa somente os números da posição 0 e 1, nesse caso apenas os dois primeiros números;
                p1.Telefone = semMaskTelefone.Substring(2); //puxa todos os números da posição 2 em diante;


                //Verifica qual RadioButton foi selecionado no Form e verifica se está preenchido no "else";
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


                //Verifica se a CheckBox está marcando se possui filhos, se não possui filhos ou se foi marcada ou não.
                if (chkPossuiFilhos.CheckState == CheckState.Checked)
                {
                    p1.PossuiFilhos = true;//SE marcado, retorna true "Verdadeiro" a opção que possui filhos
                }
                else if (chkPossuiFilhos.CheckState == CheckState.Unchecked)
                {
                    p1.PossuiFilhos = false;//SE não estiver marcado, retorna false "falso" a opção que possui filhos
                }
                else // Caso nenhuma das opções:
                {
                    Erro("Faltou marcar se tem Filhos!");
                    return;
                }

                Pessoa.ListaPessoas.Add(p1); //Adiciona Pessoa (p1) na lista de Pessoas.

                MessageBox.Show("Cadastro realizado com sucesso!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); //Mensagem de cadastro realizado.

                txtCodigo.Text = (Pessoa.ListaPessoas.Count + 1).ToString(); //Aumenta o códido incrementado +1 somado no anterior.

                LimparFormulario(); //Limpa o formulário para novo cadsatramento ou finalização.

            }

        }

        private void FormCadastrarPessoa_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = (Pessoa.ListaPessoas.Count + 1).ToString(); //Ao carregar o formulário, incrementa +1, sendo assim o primeiro usuário é 0+1 = 1;
            txtCodigo.Enabled = false; //Deixa o txtBox sem alteração pelo usuário
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;//Deixa a seleção indeterminada da opção possui filhos, sendo possível validar se foi ou não preenchida.
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha o programa
        }
    }
}
