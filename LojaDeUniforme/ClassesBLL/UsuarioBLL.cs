﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeUniforme.ClassesBLL
{
    class UsuarioBLL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string nomedeusuario { get; set; }
        public string senha { get; set; }
        public DateTime dataultimamodificacao { get; set; }
        public string usuarioultimamodificacao { get; set; }
    }
}
