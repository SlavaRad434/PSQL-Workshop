using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Workshop.DTO;
using Workshop.Models;
using Workshop.Mapper;

namespace Workshop.Services
{
    public abstract class EntityServiceBase<TEntity, TDto> : IEntityService<TEntity, TDto>
        where TEntity : class
        where TDto : IEntityDto
    {
        protected abstract int GetEntityId(TEntity entity); // Должен быть реализован в наследниках

        protected readonly AutoRepairContext _db;
        protected readonly IEntityMapper<TEntity, TDto> _mapper;
        protected readonly DbSet<TEntity> _set;

        protected EntityServiceBase(
            AutoRepairContext db,
            IEntityMapper<TEntity, TDto> mapper)
        {
            _db = db;
            _mapper = mapper;
            _set = _db.Set<TEntity>(); // Получаем DbSet автоматически
        }

        public List<TDto> GetAll() =>
            _set.AsNoTracking()
                .AsEnumerable()
                .Select(e => _mapper.ToDto(e))
                .ToList();

        public List<TDto> Find(Expression<Func<TEntity, bool>> predicate) =>
            _set.Where(predicate)
                .AsNoTracking()
                .AsEnumerable()
                .Select(e => _mapper.ToDto(e))
                .ToList();

        public void Add(TDto dto)
        {
            var entity = _mapper.CreateEntity(dto);
            _set.Add(entity);
            _db.SaveChanges();
            dto.Id = GetEntityId(entity);
        }

        public void Update(TDto dto)
        {
            var entity = _set.Find(dto.Id);
            if (entity == null) return;

            _mapper.UpdateEntity(dto, entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _set.Find(id);
            if (entity == null) return;

            _set.Remove(entity);
            _db.SaveChanges();
        }
    }
}