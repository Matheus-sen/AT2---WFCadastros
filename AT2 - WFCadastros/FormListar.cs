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
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            dgvListaCategorias.DataSource = Categoria.ListaCategorias;
        }
    }
}
