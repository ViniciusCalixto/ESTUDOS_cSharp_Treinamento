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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Pet = new HashSet<Pet>();
        }
    
        public int id_cliente { get; set; }
        public string nome_cliente { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public System.DateTime data_nascimento { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public Nullable<int> id_estado { get; set; }
        public Nullable<int> id_cidade { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public System.DateTime data_cadastro { get; set; }
        public int status_cliente { get; set; }
    
        public virtual Municipio Municipio { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pet> Pet { get; set; }
    }
}