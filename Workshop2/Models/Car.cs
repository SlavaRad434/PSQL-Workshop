using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop2.Models
{
    [Table("cars", Schema = "auto_repair")]
    public class Car
    {
            public Car()
            {
                Repairs = new HashSet<Repair>();
            }

            [Key]
            [Column("car_id")]
            public int CarId { get; set; }

            [Required, MaxLength(20)]
            [Column("vin")]
            public string Vin { get; set; }

            [MaxLength(20)]
            [Column("body_number")]
            public string BodyNumber { get; set; }

            [MaxLength(20)]
            [Column("engine_number")]
            public string EngineNumber { get; set; }

            [MaxLength(100)]
            [Column("owner_name")]
            public string OwnerName { get; set; }

            [MaxLength(20)]
            [Column("owner_phone")]
            public string OwnerPhone { get; set; }

            public virtual ICollection<Repair> Repairs { get; set; }
        }
}
