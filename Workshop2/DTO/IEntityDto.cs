using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.DTO
{
    public interface IEntityDto
    {
        object Id { get; set; }
    }

    public interface IEntityDto<T> : IEntityDto
    {
        new T Id { get; set; }
    }
}
