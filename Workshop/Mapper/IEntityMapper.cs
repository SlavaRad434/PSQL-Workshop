using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Workshop.Mapper
    {
            public interface IEntityMapper<TEntity, TDto>
            {
                TDto ToDto(TEntity entity);

                TEntity CreateEntity(TDto dto);

                void UpdateEntity(TDto dto, TEntity entity);
            }
    }
