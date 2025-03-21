using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Pessoa
    {
        public Pessoa(int codigo, string? cpf, string? nomeCompleto, string? email, string? dddTelefone, string? tipoTelefone, bool possuiFilhos)
        {
            Codigo = codigo;
            Cpf = cpf;
            NomeCompleto = nomeCompleto;
            Email = email;
            DddTelefone = dddTelefone;
            TipoTelefone = tipoTelefone;
            PossuiFilhos = possuiFilhos;
        }
        public Pessoa()
        {

        }

        public static List<Pessoa> ListaPessoas = new List<Pessoa>();


        public int Codigo { get; set; }
        public string? Cpf { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Email { get; set; }
        public string? DddTelefone { get; set; }
        public string? TipoTelefone { get; set; }
        public bool PossuiFilhos { get; set; }

    }

}
