namespace ExemploEngenhariaReversa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ENDERECO")]
    public partial class ENDERECO
    {
        [Key]
        public int idEndereco { get; set; }

        [Required]
        [StringLength(100)]
        public string rua { get; set; }

        [Required]
        [StringLength(100)]
        public string bairro { get; set; }

        [Required]
        [StringLength(100)]
        public string cidade { get; set; }

        [Required]
        [StringLength(20)]
        public string CEP { get; set; }

        public int idCliente { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }
    }
}
