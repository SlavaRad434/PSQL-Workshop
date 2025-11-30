using Workshop.DTO;
using Workshop.Models;

namespace Workshop.Mapper
{
    public class RepairMapper : IEntityMapper<Repair, RepairDto>
    {
        public RepairDto ToDto(Repair entity)
        {
            return new RepairDto
            {
                Id = entity.RepairId,
                CarId = entity.CarId,
                DefectId = entity.DefectId,
                BrigadeId = entity.BrigadeId,
                ReceivedAt = entity.ReceivedAt,
                FinishedAt = entity.FinishedAt,
                LaborCost = entity.LaborCost,
                PartsCost = entity.PartsCost,
                TotalCost = entity.TotalCost,
                Status = entity.Status,
                CarVin = entity.Car?.Vin,
                DefectName = entity.Defect?.Name,
                BrigadeName = entity.Brigade?.Name,
                WorkshopName = entity.Brigade?.Workshop?.Name
            };
        }

        public Repair CreateEntity(RepairDto dto)
        {
            return new Repair
            {
                CarId = dto.CarId,
                DefectId = dto.DefectId,
                BrigadeId = dto.BrigadeId,
                ReceivedAt = dto.ReceivedAt,
                FinishedAt = dto.FinishedAt,
                LaborCost = dto.LaborCost,
                PartsCost = dto.PartsCost,
                TotalCost = dto.TotalCost,
                Status = dto.Status
            };
        }

        public void UpdateEntity(RepairDto dto, Repair entity)
        {
            entity.CarId = dto.CarId;
            entity.DefectId = dto.DefectId;
            entity.BrigadeId = dto.BrigadeId;
            entity.ReceivedAt = dto.ReceivedAt;
            entity.FinishedAt = dto.FinishedAt;
            entity.LaborCost = dto.LaborCost;
            entity.PartsCost = dto.PartsCost;
            entity.TotalCost = dto.TotalCost;
            entity.Status = dto.Status;
        }
    }
}