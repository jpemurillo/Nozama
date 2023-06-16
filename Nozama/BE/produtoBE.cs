using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozama.BE
{
    public class produtoBE
    {
        public VO.produto cadastroproduto { get; set; }
        private DAO.ProdutoDAO dao { get; set; }
        public produtoBE()
        {
            dao = new DAO.ProdutoDAO();
        }

        public void create()
        {
            dao.cadastroproduto = cadastroproduto;
            dao.create();
        }
        public void update()
        {
            dao.cadastroproduto = cadastroproduto;
            dao.update();
        }
        public void delete()
        {
            dao.cadastroproduto = cadastroproduto;
            dao.delete();
        }
        public List<VO.produto> list()
        {
            return dao.list(); ;
        }

    }
}

