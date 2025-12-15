using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop2.Models
{
    [Table("personnel", Schema = "auto_repair")]
    public class Personnel
    {
        // === PRIMARY KEY ===
        [Key]
        [StringLength(12)]
        [Column("person_inn")]
        public string PersonInn { get; set; }

        // Brigade (nullable FK)
        [Column("brigade_id")]
        public int? BrigadeId { get; set; }

        // Full Name
        [Required]
        [MaxLength(120)]
        [Column("full_name")]
        public string FullName { get; set; }

        // Role
        [MaxLength(50)] 
        [Column("role")]
        public string Role { get; set; }

        // Date
        [Column("hired_at")]
        public DateTime HiredAt { get; set; }

        // Navigation property to Brigade
        [ForeignKey("BrigadeId")]
        public virtual Brigade Brigade { get; set; }
    }
}
