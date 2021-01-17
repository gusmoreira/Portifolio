using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeUniforme.ClassesBLL
{
    class UniformesBLL
    {
        public int id { get; set; }
        public string peca { get; set; }
        public string categoria { get; set; }
        public string tamanho { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }
        public DateTime dataultimamodificacao { get; set; }
        public string usuarioultimamodificacao { get; set; }
    }
}
