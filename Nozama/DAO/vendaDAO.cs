using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Nozama.DAO
{
    class vendaDAO : BaseDAO
    {
        public VO.venda totalvendas;

        public List<VO.venda> listavendas;
        public VO.venda nome { get; set; }

        public void create()
        {
            sql = "insert into venda(nome,descricao,preco) values (@nome,@desc,@preco)";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@nome", totalvendas.nome));
            parametros.Add(new MySqlParameter("@desc", totalvendas.descricao));
            parametros.Add(new MySqlParameter("@preco", totalvendas.preco));
            execute();

        }

        public void update()
        {
            this.sql = "update venda set nome=@nome,descricao=@desc,preco=@preco where id=@id";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@id", totalvendas.id));
            parametros.Add(new MySqlParameter("@nome", totalvendas.nome));
            parametros.Add(new MySqlParameter("@desc", totalvendas.descricao));
            parametros.Add(new MySqlParameter("@preco", totalvendas.preco));
            execute();
        }
        public void delete()
        {
            this.sql = "delete from venda where id=@id";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@id", totalvendas.id));
            execute();
        }
        public List<VO.venda> list()
        {
            listavendas = new List<VO.venda>();
            this.sql = "select * from venda";
            using (var dr = executeReader())
            {
                while (dr.Read())
                {
                    totalvendas = new VO.venda();
                    totalvendas.id = Convert.ToInt32(dr["ID"]);
                    totalvendas.nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    totalvendas.descricao = dr["descricao"] != DBNull.Value ? dr["descricao"].ToString() : "";
                    totalvendas.preco = Convert.ToInt32(dr["preco"]);
                    listavendas.Add(totalvendas);
                }
            }
            return listavendas;
        }
    }
}
