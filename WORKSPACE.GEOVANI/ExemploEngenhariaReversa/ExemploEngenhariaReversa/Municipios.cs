namespace ExemploEngenhariaReversa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Municipios
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string CodigoIbge { get; set; }

        public int Estado_Id { get; set; }

        public virtual Estadoes Estadoes { get; set; }
    }
}
