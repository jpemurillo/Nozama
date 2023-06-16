using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozama.BE
{
    public class vendaBE
    {
        public VO.venda totalvendas { get; set; }
        private DAO.vendaDAO dao { get; set; }
        public vendaBE()
        {
            dao = new DAO.vendaDAO();
        }
        public void create()
        {
            dao.totalvendas = totalvendas;
            dao.create();
        }
        public void update()
        {
            dao.totalvendas = totalvendas;
            dao.update();
        }
        public void delete()
        {
            dao.totalvendas = totalvendas;
            dao.delete();
        }

        public List<VO.venda> list()
        {
            return dao.list(); ;
        }

    }
}

