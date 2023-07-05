namespace ExemploEngenhariaReversa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            ENDERECO = new HashSet<ENDERECO>();
        }

        [Key]
        public int idCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string nomeCliente { get; set; }

        public DateTime? DataNascimento { get; set; }

        [Required]
        [StringLength(20)]
        public string CPF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENDERECO> ENDERECO { get; set; }
    }
}
