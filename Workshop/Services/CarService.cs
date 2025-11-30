using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Workshop.DTO;
using Workshop.Mapper;
using Workshop.Models;

namespace Workshop.Services
{

    public class DefectService : EntityServiceBase<Defect, DefectDto>
    {
        public DefectService(AutoRepairContext db)
            : base(db, new DefectMapper())
        {
        }

        protected override object GetEntityId(Defect entity)
        {
            return entity.DefectId;
        }
    }

    public class PartService : EntityServiceBase<Part, PartDto>
    {
        public PartService(AutoRepairContext db)
            : base(db, new PartMapper())
        {
        }

        protected override object GetEntityId(Part entity)
        {
            return entity.PartId;
        }

        public override List<PartDto> GetAll()
        {
            try
            {
                return _db.Parts
                    .Include(p => p.Defect)
                    .Include(p => p.Car)
                    .AsNoTracking()
                    .ToList()
                    .Select(e => _mapper.ToDto(e))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении данных: {ex.Message}", ex);
            }
        }
    }

    public class PersonnelService : EntityServiceBase<Personnel, PersonnelDto>
    {
        public PersonnelService(AutoRepairContext db)
            : base(db, new PersonnelMapper())
        {
        }

        protected override object GetEntityId(Personnel entity)
        {
            return entity.PersonInn;
        }

        public override List<PersonnelDto> GetAll() {
            try
            {
                return _db.Personnel
                    .Include(p => p.Workshop)
                    .Include(p => p.Brigade)
                    .AsNoTracking()
                    .ToList()
                    .Select(e => _mapper.ToDto(e))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении данных: {ex.Message}", ex);
            }
        }
    }

    public class RepairService : EntityServiceBase<Repair, RepairDto>
    {
        public RepairService(AutoRepairContext db)
            : base(db, new RepairMapper())
        {
        }

        protected override object GetEntityId(Repair entity)
        {
            return entity.RepairId;
        }

        public override List<RepairDto> GetAll()
        {
            try
            {
                return _db.Repairs
                    .Include(r => r.Car)
                    .Include(r => r.Defect)
                    .Include(r => r.Brigade.Workshop)
                    .AsNoTracking()
                    .ToList()
                    .Select(e => _mapper.ToDto(e))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении данных: {ex.Message}", ex);
            }
        }
    }

    public class WorkshopService : EntityServiceBase<Models.Workshop, WorkshopDto>
    {
        public WorkshopService(AutoRepairContext db)
            : base(db, new WorkshopMapper())
        {
        }

        protected override object GetEntityId(Models.Workshop entity)
        {
            return entity.WorkshopId;
        }

        public override List<WorkshopDto> GetAll()
        {
            return _db.Workshops
                .Include(w => w.Brigades)
                .Include(w => w.Personnel)
                .AsNoTracking()
                .ToList()
                .Select(e => _mapper.ToDto(e))
                .ToList();
        }
    }

    public class CarService : EntityServiceBase<Car, CarDto>
    {
        public CarService(AutoRepairContext db)
            : base(db, new CarMapper())
        {
        }

        protected override object GetEntityId(Car entity)
        {
            return entity.CarId;
        }
    }
}