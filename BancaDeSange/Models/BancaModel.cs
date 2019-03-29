namespace BancaDeSange.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BancaDeSange.Filters;

    [UserAuthentificationFilter]

    public partial class BancaModel : DbContext
    {
        

        public BancaModel()
            : base("name=BancaModel")
        {

        }

        public virtual DbSet<Banca> Bancas { get; set; }

        public virtual DbSet<Formular> Formulars { get; set; }

        public virtual DbSet<Donatori2> Donatori2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Banca>()
                .Property(e => e.Grupa_de_sange)
                .IsFixedLength();

            modelBuilder.Entity<Banca>()
                .Property(e => e.Cantitatea);
                

            modelBuilder.Entity<Banca>()
                .Property(e => e.Rh_ul)
                .IsFixedLength();

            modelBuilder.Entity<Formular>()
               .Property(e => e.Institutia)
               .IsFixedLength();

            modelBuilder.Entity<Formular>()
                .Property(e => e.Grupa)
                .IsFixedLength();

            modelBuilder.Entity<Formular>()
                .Property(e => e.Cantitatea);


            modelBuilder.Entity<Formular>()
                .Property(e => e.Rh_ul)
                .IsFixedLength();

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
