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
    public partial class telaadm : Form
    {
        public telaadm()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroprod telacadastro = new cadastroprod();
            telacadastro.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admvenda telaadmvenda = new admvenda();
            telaadmvenda.Show();
        }
    }
}
