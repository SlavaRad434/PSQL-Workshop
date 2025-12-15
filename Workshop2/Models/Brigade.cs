using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop2.Models
{
        [Table("brigades", Schema = "auto_repair")]
        public class Brigade
        {
            public Brigade()
            {
                Personnel = new HashSet<Personnel>();
                Repairs = new HashSet<Repair>();
            }

            [Key]
            [Column("brigade_id")]
            public int BrigadeId { get; set; }

            [Column("workshop_id")]
            public int WorkshopId { get; set; }

            [Required, MaxLength(100)]
            [Column("name")]
            public string Name { get; set; }

            [ForeignKey("WorkshopId")]
            
            public virtual Workshop Workshop { get; set; }

            
            public virtual ICollection<Personnel> Personnel { get; set; }

            
            public virtual ICollection<Repair> Repairs { get; set; }
        }
}
