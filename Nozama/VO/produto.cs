using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozama.VO
{
    public class produto 
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public float preco { get; set; }
        public int estoque { get; set; }

    }
}
