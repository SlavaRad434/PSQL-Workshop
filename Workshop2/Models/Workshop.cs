using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop2.Models
{
    [Table("workshops", Schema = "auto_repair")]
    public class Workshop
    {
        public Workshop()
        {
            Brigades = new HashSet<Brigade>();
        }

        [Key]
        [Column("workshop_id")]
        public int WorkshopId { get; set; }

        [Required, MaxLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [MaxLength(150)]
        [Column("address")]
        public string Address { get; set; }

        [MaxLength(20)]
        [Column("phone")]
        public string Phone { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        
        public virtual ICollection<Brigade> Brigades { get; set; }

    }
}