using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop.Models
{
    public class AutoRepairContext : DbContext
    {
        public AutoRepairContext()
            : base("name=AutoRepairConnection") // имя connectionString из App.config
        {
        }

        public virtual DbSet<Workshop> Workshops { get; set; }
        public virtual DbSet<Brigade> Brigades { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Defect> Defects { get; set; }
        public virtual DbSet<Repair> Repairs { get; set; }
        public virtual DbSet<Part> Parts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Указываем схему auto_repair
            modelBuilder.HasDefaultSchema("auto_repair");

            // Таблицы
            modelBuilder.Entity<Workshop>().ToTable("workshops");
            modelBuilder.Entity<Brigade>().ToTable("brigades");
            modelBuilder.Entity<Personnel>().ToTable("personnel");
            modelBuilder.Entity<Car>().ToTable("cars");
            modelBuilder.Entity<Defect>().ToTable("defects");
            modelBuilder.Entity<Repair>().ToTable("repairs");
            modelBuilder.Entity<Part>().ToTable("parts");

            // Связи
            modelBuilder.Entity<Brigade>()
                .HasRequired(b => b.Workshop)
                .WithMany(w => w.Brigades)
                .HasForeignKey(b => b.WorkshopId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Personnel>()
                .HasRequired(p => p.Workshop)
                .WithMany(w => w.Personnel)
                .HasForeignKey(p => p.WorkshopId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Personnel>()
                .HasOptional(p => p.Brigade)
                .WithMany(b => b.Personnel)
                .HasForeignKey(p => p.BrigadeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Repair>()
                .HasRequired(r => r.Car)
                .WithMany(c => c.Repairs)
                .HasForeignKey(r => r.CarId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Repair>()
                .HasRequired(r => r.Defect)
                .WithMany(d => d.Repairs)
                .HasForeignKey(r => r.DefectId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Repair>()
                .HasRequired(r => r.Brigade)
                .WithMany(b => b.Repairs)
                .HasForeignKey(r => r.BrigadeId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Part>()
                .HasRequired(p => p.Car)
                .WithMany(c => c.Parts)
                .HasForeignKey(p => p.CarId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Part>()
                .HasRequired(p => p.Defect)
                .WithMany(d => d.Parts)
                .HasForeignKey(p => p.DefectId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
