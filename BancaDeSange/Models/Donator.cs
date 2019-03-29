namespace BancaDeSange.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BancaDeSange.Filters;

    [UserAuthentificationFilter]
    [FilterConfig.NoDirectAccess]
    public partial class Donator : DbContext
    {
        public Donator()
            : base("name=Donator1")
        {
        }

        public virtual DbSet<Donatori2> Donatori2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donatori2>()
                .Property(e => e.Nume)
                .IsFixedLength();

            modelBuilder.Entity<Donatori2>()
                .Property(e => e.Prenume)
                .IsFixedLength();

            modelBuilder.Entity<Donatori2>()
                .Property(e => e.Grupa_de_sange)
                .IsFixedLength();

            modelBuilder.Entity<Donatori2>()
                .Property(e => e.Cantitatea);
                

            modelBuilder.Entity<Donatori2>()
                .Property(e => e.Rh_ul)
                .IsFixedLength();
        }
    }
}
