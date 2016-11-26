namespace Comp229Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Soup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoupID { get; set; }

        [Required]
        [StringLength(50)]
        public string SoupName { get; set; }

        [Required]
        [StringLength(200)]
        public string SoupShortDescription { get; set; }

        [Required]
        [StringLength(350)]
        public string SoupLongDesc { get; set; }

        public int SoupPrice { get; set; }

        [Required]
        [StringLength(100)]
        public string SoupImage { get; set; }
    }
}
