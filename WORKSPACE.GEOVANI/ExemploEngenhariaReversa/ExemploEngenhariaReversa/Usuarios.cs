namespace ExemploEngenhariaReversa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string RG { get; set; }
    }
}
