using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop.Models
{
    [Table("parts")]
    public class Part
    {
        [Key]
        [Column("part_id")]
        public int PartId { get; set; }

        [Column("defect_id")]
        public int DefectId { get; set; }

        [Column("car_id")]
        public int CarId { get; set; }

        [Required, MaxLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [ForeignKey("DefectId")]
        
        public virtual Defect Defect { get; set; }

        [ForeignKey("CarId")]
        [InverseProperty("Parts")]
        public virtual Car Car { get; set; }
    }
}