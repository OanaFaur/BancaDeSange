namespace BancaDeSange.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BancaDeSange.Filters;

    [UserAuthentificationFilter]

    public partial class SubmitModel : DbContext
    {
        public SubmitModel()
            : base("name=SubmitModel")
        {
        }

        public virtual DbSet<Utilizatori> Utilizatoris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizatori>()
                .Property(e => e.NumeUtilizator)
                .IsFixedLength();

            modelBuilder.Entity<Utilizatori>()
                .Property(e => e.Parola)
                .IsFixedLength();

            modelBuilder.Entity<Utilizatori>()
                .Property(e => e.TipDeUtilizator)
                .IsFixedLength();
        }
    }
}
