using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop.Models
{
    [Table("personnel")]
    public class Personnel
    {
        [Key, StringLength(12)]
        [Column("person_inn")]
        public string PersonInn { get; set; }

        [Column("workshop_id")]
        public int WorkshopId { get; set; }

        [Column("brigade_id")]
        public int? BrigadeId { get; set; }

        [Required, MaxLength(120)]
        [Column("full_name")]
        public string FullName { get; set; }

        [MaxLength(50)]
        [Column("role")]
        public string Role { get; set; }

        [Column("hired_at")]
        public DateTime HiredAt { get; set; }

        [ForeignKey("WorkshopId")]
        
        public virtual Workshop Workshop { get; set; }

        [ForeignKey("BrigadeId")]
        
        public virtual Brigade Brigade { get; set; }
    }
}