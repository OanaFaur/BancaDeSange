namespace BancaDeSange.Models
{
    using BancaDeSange.Filters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Utilizatori")]

    [UserAuthentificationFilter]
    public partial class Utilizatori
    {
        public int Id { get; set; }

        [StringLength(20)]
        [Display(Name = "Nume utilizator")]
        public string NumeUtilizator { get; set; }

        [StringLength(20)]
        [DataType(DataType.Password)]
        public string Parola { get; set; }
        
        [StringLength(10)]
        [Display(Name = "Tip de Utilizator")]
        public string TipDeUtilizator { get; set; }

        
    }
}
