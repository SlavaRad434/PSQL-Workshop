using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Mapper
{
    public class GenericEntityMapper<TEntity, TDto> : IEntityMapper<TEntity, TDto>
        where TEntity : class, new()
        where TDto : new()
    {
        public TDto ToDto(TEntity entity)
        {
            return GenericMapper.ToDto<TEntity, TDto>(entity);
        }

        public TEntity CreateEntity(TDto dto)
        {
            return GenericMapper.CreateEntity<TDto, TEntity>(dto);
        }

        public void UpdateEntity(TDto dto, TEntity entity)
        {
            GenericMapper.ToEntity<TDto, TEntity>(dto, entity);
        }
    }
}
