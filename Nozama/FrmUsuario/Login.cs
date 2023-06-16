using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nozama
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            criar t2 = new criar();
            t2.Show();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string conectar = "server=localhost; uid=root; pwd=''; database=nozama";
            MySqlConnection conexao = new MySqlConnection(conectar);

            string sql = "Select senha,email from usuario where email=?";
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@email", txtemail.Text);

            comando.CommandType = CommandType.Text;

            conexao.Open();

            MySqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                txtsenha.Enabled = true;
                txtemail.Enabled = true;

                txtsenha.Text = dr[0].ToString();
                txtemail.Text = dr[1].ToString();
                MessageBox.Show("Logado!");
                this.Close();
                site t5 = new site();
                t5.Show();

            }
            else
            {
                txtemail.Text = "";
                txtsenha.Text = "";
                label6.Visible = true;
            }
            
        }
    }
}
