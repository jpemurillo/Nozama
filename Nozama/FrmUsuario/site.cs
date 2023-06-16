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
    public partial class site : Form
    {
        public site()
        {
            InitializeComponent();
        }

        private void site_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btncomprar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionado ao carrinho!");
          
            
        }

        private void btncomprar2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionado ao carrinho!");
           
            
        }

        private void btncomprar3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionado ao carrinho!");
            
            
        }

        private void btncomprar5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionado ao carrinho!");
            
            
        }

        private void btnoutrosprodutos_Click(object sender, EventArgs e)
        {
            comprar t6 = new comprar();
            t6.Show();
        }
    }
}
