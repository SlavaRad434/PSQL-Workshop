using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop2.Models
{
    [Table("parts", Schema = "auto_repair")]
    public class Part
    {
        [Key]
        [Column("part_id")]
        public int PartId { get; set; }

        [Column("defect_id")]
        public int DefectId { get; set; }

        [Required, MaxLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [ForeignKey("DefectId")]
        [InverseProperty("Parts")]
        public virtual Defect Defect { get; set; }
    }

}