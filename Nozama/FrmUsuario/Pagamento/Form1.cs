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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cartao t12 = new cartao();
            t12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pix t11 = new pix();
            t11.Show();


        }
    }
}
