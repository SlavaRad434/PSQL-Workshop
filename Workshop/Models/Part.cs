using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop.Models
{
    public class Part
    {
        [Key]
        public int PartId { get; set; }

        public int DefectId { get; set; }
        public int CarId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("DefectId")]
        public virtual Defect Defect { get; set; }

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}
