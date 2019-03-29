namespace BancaDeSange.Models
{
    using BancaDeSange.Filters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [UserAuthentificationFilter]
    [Table("Banca")]
    public partial class Banca
    {
        public int Id { get; set; }

       
        [StringLength(10)]
        [Display(Name ="Grupa de sange")]
        [Column("Grupa de sange")]
        public string Grupa_de_sange { get; set; }

        
        public int Cantitatea { get; set; }

        
        [StringLength(10)]
        [Display(Name="Rh-ul")]
        [Column("Rh-ul")]
        public string Rh_ul { get; set; }

       
     
    }

    
}
