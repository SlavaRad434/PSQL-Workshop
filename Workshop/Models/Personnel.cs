using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop.Models
{
    public class Personnel
    {
        [Key, StringLength(12)]
        public string PersonInn { get; set; }

        public int WorkshopId { get; set; }
        public int? BrigadeId { get; set; }

        [Required, MaxLength(120)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string Role { get; set; }

        public DateTime HiredAt { get; set; }

        [ForeignKey("WorkshopId")]
        public virtual Workshop Workshop { get; set; }

        [ForeignKey("BrigadeId")]
        public virtual Brigade Brigade { get; set; }
    }
}
