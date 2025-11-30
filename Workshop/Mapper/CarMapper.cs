
using System.Linq;
using Workshop.DTO;
using Workshop.Models;

namespace Workshop.Mapper
{
    public class CarMapper : IEntityMapper<Car, CarDto>
    {
        public CarDto ToDto(Car entity)
        {
            return new CarDto
            {
                Id = entity.CarId,
                Vin = entity.Vin,
                BodyNumber = entity.BodyNumber,
                EngineNumber = entity.EngineNumber,
                OwnerName = entity.OwnerName,
                OwnerPhone = entity.OwnerPhone
            };
        }

        public Car CreateEntity(CarDto dto)
        {
            return new Car
            {
                Vin = dto.Vin,
                BodyNumber = dto.BodyNumber,
                EngineNumber = dto.EngineNumber,
                OwnerName = dto.OwnerName,
                OwnerPhone = dto.OwnerPhone
            };
        }

        public void UpdateEntity(CarDto dto, Car entity) // Исправлена сигнатура
        {
            entity.Vin = dto.Vin;
            entity.BodyNumber = dto.BodyNumber;
            entity.EngineNumber = dto.EngineNumber;
            entity.OwnerName = dto.OwnerName;
            entity.OwnerPhone = dto.OwnerPhone;
        }
    }

        public class BrigadeMapper : IEntityMapper<Brigade, BrigadeDto>
        {
            public BrigadeDto ToDto(Brigade entity)
            {
                return new BrigadeDto
                {
                    Id = entity.BrigadeId,
                    WorkshopId = entity.WorkshopId,
                    Name = entity.Name,
                    WorkshopName = entity.Workshop?.Name
                };
            }

            public Brigade CreateEntity(BrigadeDto dto)
            {
                return new Brigade
                {
                    WorkshopId = dto.WorkshopId,
                    Name = dto.Name
                };
            }

            public void UpdateEntity(BrigadeDto dto, Brigade entity)
            {
                entity.WorkshopId = dto.WorkshopId;
                entity.Name = dto.Name;
            }
        }

        public class DefectMapper : IEntityMapper<Defect, DefectDto>
        {
            public DefectDto ToDto(Defect entity)
            {
                return new DefectDto
                {
                    Id = entity.DefectId,
                    Name = entity.Name,
                    BaseLaborCost = entity.BaseLaborCost
                };
            }

            public Defect CreateEntity(DefectDto dto)
            {
                return new Defect
                {
                    Name = dto.Name,
                    BaseLaborCost = dto.BaseLaborCost
                };
            }

            public void UpdateEntity(DefectDto dto, Defect entity)
            {
                entity.Name = dto.Name;
                entity.BaseLaborCost = dto.BaseLaborCost;
            }
        }

        public class PartMapper : IEntityMapper<Part, PartDto>
        {
            public PartDto ToDto(Part entity)
            {
                return new PartDto
                {
                    Id = entity.PartId,
                    DefectId = entity.DefectId,
                    CarId = entity.CarId,
                    Name = entity.Name,
                    UnitPrice = entity.UnitPrice,
                    Quantity = entity.Quantity,
                    DefectName = entity.Defect?.Name,
                    CarVin = entity.Car?.Vin
                };
            }

            public Part CreateEntity(PartDto dto)
            {
                return new Part
                {
                    DefectId = dto.DefectId,
                    CarId = dto.CarId,
                    Name = dto.Name,
                    UnitPrice = dto.UnitPrice,
                    Quantity = dto.Quantity
                };
            }

            public void UpdateEntity(PartDto dto, Part entity)
            {
                entity.DefectId = dto.DefectId;
                entity.CarId = dto.CarId;
                entity.Name = dto.Name;
                entity.UnitPrice = dto.UnitPrice;
                entity.Quantity = dto.Quantity;
            }
        }

        public class PersonnelMapper : IEntityMapper<Personnel, PersonnelDto>
        {
            public PersonnelDto ToDto(Personnel entity)
            {
                return new PersonnelDto
                {
                    Id = entity.PersonInn,
                    WorkshopId = entity.WorkshopId,
                    BrigadeId = entity.BrigadeId,
                    FullName = entity.FullName,
                    Role = entity.Role,
                    HiredAt = entity.HiredAt,
                    WorkshopName = entity.Workshop?.Name,
                    BrigadeName = entity.Brigade?.Name
                };
            }

            public Personnel CreateEntity(PersonnelDto dto)
            {
                return new Personnel
                {
                    PersonInn = dto.Id,
                    WorkshopId = dto.WorkshopId,
                    BrigadeId = dto.BrigadeId,
                    FullName = dto.FullName,
                    Role = dto.Role,
                    HiredAt = dto.HiredAt
                };
            }

            public void UpdateEntity(PersonnelDto dto, Personnel entity)
            {
                entity.WorkshopId = dto.WorkshopId;
                entity.BrigadeId = dto.BrigadeId;
                entity.FullName = dto.FullName;
                entity.Role = dto.Role;
                entity.HiredAt = dto.HiredAt;
            }
        }
}
