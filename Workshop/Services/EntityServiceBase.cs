using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Workshop.DTO;
using Workshop.Mapper;
using Workshop.Models;

namespace Workshop.Services
{
    public abstract class EntityServiceBase<TEntity, TDto> : IEntityService<TEntity, TDto>
        where TEntity : class
        where TDto : IEntityDto
    {
        protected abstract object GetEntityId(TEntity entity);

        protected readonly AutoRepairContext _db;
        protected readonly IEntityMapper<TEntity, TDto> _mapper;
        protected readonly DbSet<TEntity> _set;

        public EntityServiceBase(AutoRepairContext db, IEntityMapper<TEntity, TDto> mapper)
        {
            _db = db;
            _mapper = mapper;
            _set = _db.Set<TEntity>();
        }

        public virtual List<TDto> GetAll()
        {
            return _set.AsNoTracking()
                .ToList()
                .Select(e => _mapper.ToDto(e))
                .ToList();
        }

        public virtual List<TDto> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _set.Where(predicate)
                .AsNoTracking()
                .ToList()
                .Select(e => _mapper.ToDto(e))
                .ToList();
        }

        public virtual void Add(TDto dto)
        {
            var entity = _mapper.CreateEntity(dto);
            _set.Add(entity);
            _db.SaveChanges();

            var id = GetEntityId(entity);
            dto.Id = id;
        }

        public virtual void Update(TDto dto)
        {
            var entity = FindEntityById(dto.Id);
            if (entity == null) return;

            _mapper.UpdateEntity(dto, entity);
            _db.SaveChanges();
        }

        public virtual void Delete(object id)
        {
            var entity = FindEntityById(id);
            if (entity == null) return;

            _set.Remove(entity);
            _db.SaveChanges();
        }

        private TEntity FindEntityById(object id)
        {
            return _set.Find(id);
        }
    }
}