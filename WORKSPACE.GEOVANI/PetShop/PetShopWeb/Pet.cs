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
    
    public partial class Pet
    {
        public int id_pet { get; set; }
        public string nome_pet { get; set; }
        public Nullable<System.DateTime> data_nascimento { get; set; }
        public System.DateTime data_cadastro { get; set; }
        public string raca_pet { get; set; }
        public string tipo_pet { get; set; }
        public byte[] foto_pet { get; set; }
        public string nome_arquivo_foto { get; set; }
        public string MIME { get; set; }
        public int id_cliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
