using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop.Models
{
    public class Repair
    {
        public Repair()
        {
            Parts = new HashSet<Part>();
        }

        [Key]
        public int RepairId { get; set; }

        public int CarId { get; set; }
        public int DefectId { get; set; }
        public int BrigadeId { get; set; }

        public DateTime ReceivedAt { get; set; }
        public DateTime? FinishedAt { get; set; }

        public decimal LaborCost { get; set; }
        public decimal PartsCost { get; set; }
        public decimal TotalCost { get; set; }

        [MaxLength(30)]
        public string Status { get; set; }

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [ForeignKey("DefectId")]
        public virtual Defect Defect { get; set; }

        [ForeignKey("BrigadeId")]
        public virtual Brigade Brigade { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
