namespace Comp229Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appetizer")]
    public partial class Appetizer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppetizerId { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerShortdescription { get; set; }

        [Required]
        [StringLength(250)]
        public string AppetizerLongdescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AppetizerPrice { get; set; }

        [Required]
        [StringLength(10)]
        public string AppetizerImage { get; set; }
    }
}
