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
    public partial class cadastroprod : Form
    {
        private BE.produtoBE be { get; set; }
        private VO.produto cadastroproduto { get; set; }
        public cadastroprod()
        {
            InitializeComponent();
            carregar();
            ativarAlteracao(false);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limparTela();
            ativarAlteracao(false);
        }


        private void ativarAlteracao(bool ativar)
        {
            btngravar.Enabled = !ativar;
            btnalterar.Enabled = ativar;
        }


        private void carregarTela()
        {

            cadastroproduto = new VO.produto();
            cadastroproduto.id = int.Parse(txtid.Text);
            cadastroproduto.nome = txtnome.Text;
            cadastroproduto.descricao = txtdesc.Text;
            cadastroproduto.preco = float.Parse(txtpreco.Text);
            cadastroproduto.estoque = int.Parse(txtestoque.Text);
        }

        private void limparTela()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtdesc.Text = "";
            txtpreco.Text = "";
            txtestoque.Text = "";
        }
        private void carregar()
        {
            BE.produtoBE be = new BE.produtoBE();
            listproduto.DataSource = null;
            listproduto.DataSource = be.list();
            listproduto.ValueMember = "id";
            listproduto.DisplayMember = "nome";
            listproduto.Refresh();

        }


        private void receberTela()
        {
            txtid.Text = cadastroproduto.id.ToString();
            txtnome.Text = cadastroproduto.nome;
            txtdesc.Text = cadastroproduto.descricao;
            txtpreco.Text = cadastroproduto.preco.ToString();
            txtestoque.Text = cadastroproduto.estoque.ToString();
        }




        private void btngravar_Click_1(object sender, EventArgs e)
        {
            carregarTela();
            be = new BE.produtoBE();
            be.cadastroproduto = cadastroproduto;
            be.create();
            carregar();
            limparTela();
        }

        private void btnselecionar_Click_1(object sender, EventArgs e)
        {
            limparTela();
            cadastroproduto = (VO.produto)(listproduto.SelectedItem);
            receberTela();
            ativarAlteracao(true);
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            carregarTela();
            be = new BE.produtoBE();
            be.cadastroproduto = cadastroproduto;
            be.update();
            carregar();
            limparTela();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            be = new BE.produtoBE();
            be.cadastroproduto = (VO.produto)(listproduto.SelectedItem);
            be.delete();
            carregar();
            limparTela();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
