using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCodeFirst
{
    public class Municipio
    {
        public int Id { get; set; }
        public int CodIBGE { get; set; }
        public string Descricao { get; set; }

        public Estado Estado { get; set; }


    }
}
