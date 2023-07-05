namespace ExemploEngenhariaReversa
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloEngenhariaReversa : DbContext
    {
        public ModeloEngenhariaReversa()
            : base("name=ModeloEngenhariaReversa")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Estadoes> Estadoes { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estadoes>()
                .HasMany(e => e.Municipios)
                .WithRequired(e => e.Estadoes)
                .HasForeignKey(e => e.Estado_Id);
        }
    }
}
