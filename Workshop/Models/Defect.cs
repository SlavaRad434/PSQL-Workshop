using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop.Models
{
    public class Defect
    {
        public Defect()
        {
            Repairs = new HashSet<Repair>();
            Parts = new HashSet<Part>();
        }

        [Key]
        public int DefectId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }
        public decimal BaseLaborCost { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}
