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
    public partial class criar : Form
    {
        public criar()
        {
            InitializeComponent();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            string conectar = "server=localhost; uid=root; pwd=''; database=nozama";
            MySqlConnection conexao = new MySqlConnection(conectar);

            if ((txtconfirmar.Text) == (txtsenha.Text))
            {          
                string sql = "Insert Into usuario (nome,senha,email) values (" +
                "'" + txtnome.Text + "','"
                + txtsenha.Text + "','"
                + txtemail.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteReader();
                lblSenha.Visible = false;
                MessageBox.Show("Cadastrado!");
                this.Close();
                
            }
            else
            {
                txtconfirmar.Text = "";
                lblSenha.Visible = true;
                lblSenha.Text = "As senhas não são iguais.";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsenha_Leave(object sender, EventArgs e)
        {
            if (txtsenha.Text.Length < 8)
            {
                lblSenha.Visible = true;
                lblSenha.Text = "Senha deve conter no minimo 8 caracteres";
                txtsenha.Focus();
            }
        }
    }
}
