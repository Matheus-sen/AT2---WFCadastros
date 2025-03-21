using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2___WFCadastros
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string? NomeCategoria { get; set; }
        public string? Descricao { get; set; }
        public string? Status { get; set; }
        public string?DataCadastro { get; set; }

        public Categoria() { }

        public static List<Categoria> ListaCategorias = new List<Categoria>();
    }
}
