//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrimeiroExemploEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STATUS()
        {
            this.TBL_USUARIO = new HashSet<TBL_USUARIO>();
            this.FUNCIONARIO = new HashSet<FUNCIONARIO>();
        }
    
        public int ID_STATUS { get; set; }
        public string DESCRICAO_STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_USUARIO> TBL_USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FUNCIONARIO> FUNCIONARIO { get; set; }
    }
}
