using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop2.Models
{
    [Table("defects", Schema = "auto_repair")]
    public class Defect
    {
        public Defect()
        {
            Repairs = new HashSet<Repair>();
            Parts = new HashSet<Part>();
        }

        [Key]
        [Column("defect_id")]
        public int DefectId { get; set; }

        [Required, MaxLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [Column("base_labor_cost")]
        public decimal BaseLaborCost { get; set; }
        [InverseProperty("Defect")]
        public virtual ICollection<Repair> Repairs { get; set; }
        [InverseProperty("Defect")]
        public virtual ICollection<Part> Parts { get; set; }
    }
}
