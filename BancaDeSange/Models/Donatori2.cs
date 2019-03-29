namespace BancaDeSange.Models
{
    using BancaDeSange.Filters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [UserAuthentificationFilter]

    [Table("Donatori2")]
    public partial class Donatori2
    {
        

        public int Id { get; set; }

        [StringLength(30)]
        public string Nume { get; set; }

        [StringLength(30)]
        public string Prenume { get; set; }

        [StringLength(10)]
        [Display(Name ="Grupa de sange")]
        [Column("Grupa_de_sange")]
        public string Grupa_de_sange { get; set; }

        
        public int Cantitatea { get; set; }

        [StringLength(10)]
        [Display(Name ="Rh-ul")]
        [Column("Rh_ul")]
        public string Rh_ul { get; set; }
    }
}
