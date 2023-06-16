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
    public partial class comprar : Form
    {
        private BE.produtoBE be { get; set; }
        private BE.vendaBE ven { get; set; }
        
        private VO.produto vendaproduto { get; set; }
        private VO.venda listavendas { get; set; }

        public comprar()
        {
            InitializeComponent();
            carregar();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void carregarTelavenda()
        {

            listavendas = new VO.venda();
            listavendas.nome = txtnome.Text;
            listavendas.descricao = txtdesc.Text;
            listavendas.preco = float.Parse(txtpreco.Text);

        }

        private void carregarTela()
        {

            vendaproduto = new VO.produto();
            vendaproduto.id = int.Parse(txtid.Text);
            vendaproduto.nome = txtnome.Text;
            vendaproduto.descricao = txtdesc.Text;
            vendaproduto.preco = float.Parse(txtpreco.Text);

        }

        private void limparTela()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtdesc.Text = "";
            txtpreco.Text = "";

        }
        private void carregarvenda()
        {
            BE.vendaBE ven = new BE.vendaBE();
            listcarrinho.DataSource = null;
            listcarrinho.DataSource = ven.list();
            listcarrinho.ValueMember = "id";
            listcarrinho.DisplayMember = "nome";
            listcarrinho.Refresh();

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
            txtid.Text = vendaproduto.id.ToString();
            txtnome.Text = vendaproduto.nome;
            txtdesc.Text = vendaproduto.descricao;
            txtpreco.Text = vendaproduto.preco.ToString();

        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
            limparTela();
            vendaproduto = (VO.produto)(listproduto.SelectedItem);
            receberTela();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarTelavenda();
            ven = new BE.vendaBE();
            ven.totalvendas = listavendas;
            ven.create();
            carregarvenda();
            Form1 t10 = new Form1();
            t10.Show();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            VO.produto v = (VO.produto)(listproduto.SelectedItem);
            listcarrinho.Items.Add(v);
            listcarrinho.ValueMember = "id";
            listcarrinho.DisplayMember = "nome";
            listcarrinho.Refresh();

            float soma = 0;
            foreach (var item in listcarrinho.Items)
            {
                VO.produto v2 = (VO.produto)item;
                soma = soma + v2.preco;
                

            }

            label4.Text = "TOTAL: R$ " + soma.ToString();


        }

        private void btnlimparcarrinho_Click(object sender, EventArgs e)
        {
            listcarrinho.Items.Clear();
            label4.Text = "TOTAL: ";
        }
    }
}
