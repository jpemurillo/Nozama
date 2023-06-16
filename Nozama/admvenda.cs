using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nozama
{
    public partial class admvenda : Form
    {
        public admvenda()
        {
            InitializeComponent();
            List<VO.venda> lista = new List<VO.venda>();
            BE.vendaBE be = new BE.vendaBE();
            lista = be.list();
            int totprodutos = lista.Count();

            label1.Text = "Total de Vendas: "+totprodutos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
