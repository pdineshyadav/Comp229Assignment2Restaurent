namespace Comp229Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dessert
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DessertId { get; set; }

        [Required]
        [StringLength(20)]
        public string DessertName { get; set; }

        [Required]
        [StringLength(250)]
        public string DessertShortDesc { get; set; }

        [Required]
        [StringLength(350)]
        public string DessertLongDesc { get; set; }

        public int DessertPrice { get; set; }

        [Required]
        [StringLength(100)]
        public string DessertImage { get; set; }
    }
}
