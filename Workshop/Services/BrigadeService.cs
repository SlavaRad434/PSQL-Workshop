using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Workshop.DTO;
using Workshop.Mapper;
using Workshop.Models;

namespace Workshop.Services
{
    public class BrigadeService : EntityServiceBase<Brigade, BrigadeDto>
    {
        public BrigadeService(AutoRepairContext db)
            : base(db, new BrigadeMapper())
        {
        }

        protected override object GetEntityId(Brigade entity)
        {
            return entity.BrigadeId;
        }

        public override List<BrigadeDto> GetAll()
        {
            return _db.Brigades
                .Include(b => b.Workshop)
                .AsNoTracking()
                .ToList()
                .Select(e => _mapper.ToDto(e))
                .ToList();
        }
    }
}