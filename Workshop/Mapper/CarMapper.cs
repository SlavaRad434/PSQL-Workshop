using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
}
