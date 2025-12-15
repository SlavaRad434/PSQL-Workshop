using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop2.Models
{
    [Table("repairs", Schema = "auto_repair")]
    public class Repair
    {
        public Repair()
        {
        }

        [Key]
        [Column("repair_id")]
        public int RepairId { get; set; }

        [Column("car_id")]
        public int CarId { get; set; }

        [Column("defect_id")]
        public int DefectId { get; set; }

        [Column("brigade_id")]
        public int BrigadeId { get; set; }

        [Column("received_at")]
        public DateTime ReceivedAt { get; set; }

        [Column("finished_at")]
        public DateTime? FinishedAt { get; set; }

        [Column("labor_cost")]
        public decimal LaborCost { get; set; }

        [Column("parts_cost")]
        public decimal PartsCost { get; set; }

        [Column("total_cost")]
        public decimal TotalCost { get; set; }

        [MaxLength(30)]
        [Column("status")]
        public string Status { get; set; }

        [ForeignKey("CarId")]
        
        public virtual Car Car { get; set; }

        [ForeignKey("DefectId")]
        
        public virtual Defect Defect { get; set; }

        [ForeignKey("BrigadeId")]
        
        public virtual Brigade Brigade { get; set; }

        
    }
}