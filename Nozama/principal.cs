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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                Login t3 = new Login();
                t3.Show();
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Administrador t4 = new Administrador();
            t4.Show();
        }
    }
    
}
