namespace ExemploEngenhariaReversa
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelEngenhariaReversa : DbContext
    {
        public ModelEngenhariaReversa()
            : base("name=ModelEngenhariaReversa")
        {
        }

        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<ENDERECO> ENDERECO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.nomeCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.ENDERECO)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.rua)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.CEP)
                .IsUnicode(false);
        }
    }
}
