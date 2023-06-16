using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Nozama.DAO
{
    public class ProdutoDAO : BaseDAO
    {
        public VO.produto cadastroproduto;
        public List<VO.produto> Listaproduto;
        public VO.produto id { get; set; }

        public void create()
        {
            sql = "insert into produto(nome,descricao,preco,estoque) values (@nome,@desc,@preco,@estoque)";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@nome", cadastroproduto.nome));
            parametros.Add(new MySqlParameter("@desc", cadastroproduto.descricao));
            parametros.Add(new MySqlParameter("@preco", cadastroproduto.preco));
            parametros.Add(new MySqlParameter("@estoque", cadastroproduto.estoque));
            execute();

        }

        public void update()
        {
            this.sql = "update produto set nome=@nome,descricao=@desc,preco=@preco,estoque=@estoque where id=@id";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@id", cadastroproduto.id));
            parametros.Add(new MySqlParameter("@nome", cadastroproduto.nome));
            parametros.Add(new MySqlParameter("@desc", cadastroproduto.descricao));
            parametros.Add(new MySqlParameter("@preco", cadastroproduto.preco));
            parametros.Add(new MySqlParameter("@estoque", cadastroproduto.estoque));
            execute();
        }
        public void delete()
        {
            this.sql = "delete from produto where id=@id";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@id", cadastroproduto.id));
            execute();
        }
        public List<VO.produto> list()
        {
            Listaproduto = new List<VO.produto>();
            this.sql = "select * from produto";
            using (var dr = executeReader())
            {
                while (dr.Read())
                {
                    cadastroproduto = new VO.produto();
                    cadastroproduto.id = Convert.ToInt32(dr["ID"]);
                    cadastroproduto.nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    cadastroproduto.descricao = dr["descricao"] != DBNull.Value ? dr["descricao"].ToString() : "";
                    cadastroproduto.preco = Convert.ToInt32(dr["preco"]);
                    cadastroproduto.estoque = Convert.ToInt32(dr["estoque"]);
                    Listaproduto.Add(cadastroproduto);
                }
            }
            return Listaproduto;
        }
    }
}

