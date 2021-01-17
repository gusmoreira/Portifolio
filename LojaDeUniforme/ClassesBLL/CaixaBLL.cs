using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeUniforme.ClassesBLL
{
    class CaixaBLL
    {
        public int idlista { get; set; }
        public string categoria { get; set; }
        public string peca { get; set; }
        public string tamanho { get; set; }
        public string preco { get; set; }
        public string quantidade { get; set; }
        public string total { get; set; }

        public int fk_Lista { get; set; }
        public string Fk_RaAluno { get; set; }
        public string Fk_CursoAluno { get; set; }
        public string Fk_NomeAluno { get; set; }
        public string Fk_NomeUsuario { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal SubTotal { get; set; }
        public int Desconto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public decimal ValorTotal { get; set; }
        public string Observacao { get; set; }
    }
}
