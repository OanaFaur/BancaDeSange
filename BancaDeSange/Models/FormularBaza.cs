namespace BancaDeSange.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BancaDeSange.Filters;
    

    [UserAuthentificationFilter]
    [FilterConfig.NoDirectAccess]
    public partial class FormularBaza : DbContext
    {
        public FormularBaza()
            : base("name=FormularBaza")
        {
        }

        public virtual DbSet<Formular> Formulars { get; set; }
        [FilterConfig.NoDirectAccess]
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
        }
    }
}
