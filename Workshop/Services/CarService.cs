using Workshop.Models;
using Workshop.DTO;
using Workshop.Mapper;
using System.Collections.Generic;
using System.Data.Entity;
using Workshop.Services;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Workshop.Services
{
    public class CarService : EntityServiceBase<Car, CarDto>
    {
        public CarService(AutoRepairContext db)
            : base(db, new CarMapper())
        {
        }

        protected override int GetEntityId(Car entity)
        {
            return entity.CarId;
        }
    }
    //public class CarService : IEntityService<Car, CarDto>
    //{
    //    private readonly AutoRepairContext _db;
    //    private readonly CarMapper _mapper = new CarMapper();

    //    public CarService(AutoRepairContext db)
    //    {
    //        _db = db;
    //    }

    //    public List<CarDto> GetAll()
    //    {
    //        return _db.Cars
    //                  .AsNoTracking()
    //                  .ToList()
    //                  .Select(entity => _mapper.ToDto(entity)) // Исправлено
    //                  .ToList();
    //    }

    //    public void Add(CarDto dto)
    //    {
    //        var entity = _mapper.CreateEntity(dto); // Исправлено
    //        _db.Cars.Add(entity);
    //        _db.SaveChanges();
    //        dto.Id = entity.CarId;
    //    }

    //    public void Update(CarDto dto)
    //    {
    //        var entity = _db.Cars.Find(dto.Id);
    //        if (entity == null) return;
    //        _mapper.UpdateEntity(dto, entity); // Исправлено
    //        _db.SaveChanges();
    //    }

    //    public void Delete(int id)
    //    {
    //        var entity = _db.Cars.Find(id);
    //        if (entity == null) return;
    //        _db.Cars.Remove(entity);
    //        _db.SaveChanges();
    //    }

    //    public List<CarDto> Find(Expression<Func<Car, bool>> predicate)
    //    {
    //        return _db.Cars
    //                  .Where(predicate)
    //                  .ToList()
    //                  .Select(entity => _mapper.ToDto(entity)) // Исправлено
    //                  .ToList();
    //    }
    //}
}


