﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCodeFirst
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<DateTime> DataNascimento { get; set; }
        public string RG { get; set; }
    }
}
