//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetShopWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.DadosUsuario = new HashSet<DadosUsuario>();
        }
    
        public int id_usuario { get; set; }
        public string nome_usuario { get; set; }
        public string login_usuario { get; set; }
        public string senha_usuario { get; set; }
        public Nullable<System.DateTime> data_ultimo_login { get; set; }
        public int status_usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DadosUsuario> DadosUsuario { get; set; }
        public virtual Status Status { get; set; }
    }
}
