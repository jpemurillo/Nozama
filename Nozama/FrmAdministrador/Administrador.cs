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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string conectar = "server=localhost; uid=root; pwd=''; database=nozama";
            MySqlConnection conexao = new MySqlConnection(conectar);

            string sql = "Select nozamaid,senha from adm where nozamaid=?";
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nozamaid", txtnozamaid.Text);

            comando.CommandType = CommandType.Text;

            conexao.Open();

            MySqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                txtnozamaid.Enabled = true;
                txtsenhaadm.Enabled = true;

                txtnozamaid.Text = dr[0].ToString();
                txtsenhaadm.Text = dr[1].ToString();
                MessageBox.Show("Bem Vindo");
                telaadm t5 = new telaadm();
                t5.Show();
            }
            else
            {
                txtnozamaid.Text = "";
                txtsenhaadm.Text = "";
                label6.Visible = true;
            }
        }
    }
}
