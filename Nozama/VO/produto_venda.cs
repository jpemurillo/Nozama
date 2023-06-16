using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozama.VO
{
    public class produto_venda
    {
        public int id { get; set; }
        public int qtd { get; set; }
        public int idProduto { get; set; }
        public int idVenda { get; set; }
    }
}
