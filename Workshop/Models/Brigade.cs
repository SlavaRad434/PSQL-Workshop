using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop.Models
{
    public class Brigade
    {
        public Brigade()
        {
            Personnel = new HashSet<Personnel>();
            Repairs = new HashSet<Repair>();
        }

        [Key]
        public int BrigadeId { get; set; }

        public int WorkshopId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("WorkshopId")]
        public virtual Workshop Workshop { get; set; }

        public virtual ICollection<Personnel> Personnel { get; set; }
        public virtual ICollection<Repair> Repairs { get; set; }
    }
}
