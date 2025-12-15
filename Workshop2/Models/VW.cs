using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Models
{
    // Производительность бригад
    [Table("vw_brigade_performance", Schema = "auto_repair")]
    public class BrigadePerformance
    {
        [Key]
        [Column("brigade_id")]
        public int BrigadeId { get; set; }

        [Column("brigade")]
        public string Brigade { get; set; }

        [Column("total_repairs")]
        public int TotalRepairs { get; set; }

        [Column("total_income")]
        public decimal TotalIncome { get; set; }
    }

    // Автомобили
    [Table("vw_cars", Schema = "auto_repair")]
    public class CarView
    {
        [Key]
        [Column("car_id")]
        public int CarId { get; set; }

        [Column("vin")]
        public string Vin { get; set; }

        [Column("owner_name")]
        public string OwnerName { get; set; }

        [Column("owner_phone")]
        public string OwnerPhone { get; set; }
    }

    // Стоимость ремонта
    [Table("vw_repair_cost", Schema = "auto_repair")]
    public class RepairCostView
    {
        [Key]
        [Column("repair_id")]
        public int RepairId { get; set; }

        [Column("vin")]
        public string Vin { get; set; }

        [Column("defect")]
        public string Defect { get; set; }

        [Column("parts_sum")]
        public decimal PartsSum { get; set; }

        [Column("labor_cost")]
        public decimal LaborCost { get; set; }

        [Column("total_sum")]
        public decimal TotalSum { get; set; }
    }

    // Подробные ремонты
    [Table("vw_repairs_detailed", Schema = "auto_repair")]
    public class RepairDetailedView
    {
        [Key]
        [Column("repair_id")]
        public int RepairId { get; set; }

        [Column("vin")]
        public string Vin { get; set; }

        [Column("defect")]
        public string Defect { get; set; }

        [Column("brigade")]
        public string Brigade { get; set; }

        [Column("received_at")]
        public DateTime ReceivedAt { get; set; }

        [Column("finished_at")]
        public DateTime? FinishedAt { get; set; }

        [Column("total_cost")]
        public decimal TotalCost { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }

}
