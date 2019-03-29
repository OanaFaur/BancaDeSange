namespace BancaDeSange.Models
{
    using BancaDeSange.Filters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    [UserAuthentificationFilter]
    [Table("Formular")]
    public partial class Formular
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Institutia { get; set; }

        [StringLength(10)]
        public string Grupa { get; set; }

        
        public int Cantitatea { get; set; }

        
        [StringLength(10)]
        [Display(Name ="Rh-ul")]
        [Column("Rh-ul")]
        public string Rh_ul { get; set; }
    }
}
