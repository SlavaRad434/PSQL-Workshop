using Workshop.DTO;
using Workshop.Models;

namespace Workshop.Mapper
{
    public class WorkshopMapper : IEntityMapper<Models.Workshop, WorkshopDto>
    {
        public WorkshopDto ToDto(Models.Workshop entity)
        {
            return new WorkshopDto
            {
                Id = entity.WorkshopId,
                Name = entity.Name,
                Address = entity.Address,
                Phone = entity.Phone,
                CreatedAt = entity.CreatedAt,
                BrigadeCount = entity.Brigades?.Count ?? 0,
                PersonnelCount = entity.Personnel?.Count ?? 0
            };
        }

        public Models.Workshop CreateEntity(WorkshopDto dto)
        {
            return new Models.Workshop
            {
                Name = dto.Name,
                Address = dto.Address,
                Phone = dto.Phone,
                CreatedAt = dto.CreatedAt
            };
        }

        public void UpdateEntity(WorkshopDto dto, Models.Workshop entity)
        {
            entity.Name = dto.Name;
            entity.Address = dto.Address;
            entity.Phone = dto.Phone;
            entity.CreatedAt = dto.CreatedAt;
        }
    }
}