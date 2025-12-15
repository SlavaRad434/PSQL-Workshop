using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Models;

namespace Workshop2.Data
{
    public class AutoRepairContext : DbContext
    {
        public AutoRepairContext()
            : base("name=AutoRepairConnection")
        {
            // При необходимости: Database.SetInitializer(new CreateDatabaseIfNotExists<AutoRepairContext>());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Defect> Defects { get; set; }
        public DbSet<Brigade> Brigades { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<BrigadePerformance> BrigadePerformance { get; set; }
        public DbSet<CarView> CarsView { get; set; }
        public DbSet<RepairCostView> RepairCostView { get; set; }
        public DbSet<RepairDetailedView> RepairDetailedView { get; set; }


    }
}
