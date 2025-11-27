using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Workshop.DTO;

namespace Workshop.Services
{
    public interface IEntityService<TEntity, TDto>
        where TEntity : class
        where TDto : IEntityDto
    {
        List<TDto> GetAll();
        List<TDto> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TDto dto);
        void Update(TDto dto);
        void Delete(int id);
    }



}
