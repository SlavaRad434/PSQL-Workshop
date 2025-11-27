using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Workshop.Models
{
    public class Workshop
    {
        public Workshop()
        {
            Brigades = new HashSet<Brigade>();
            Personnel = new HashSet<Personnel>();
        }

        [Key]
        public int WorkshopId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Brigade> Brigades { get; set; }
        public virtual ICollection<Personnel> Personnel { get; set; }
    }
}
