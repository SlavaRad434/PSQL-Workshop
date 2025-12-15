using System;

namespace Workshop2.DTO
{
    public class CarDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public string Vin { get; set; }
        public string BodyNumber { get; set; }
        public string EngineNumber { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }

        object IEntityDto.Id
        {
            get => Id;
            set => Id = (int)value;
        }
    }

    public class BrigadeDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public int WorkshopId { get; set; }
        public string Name { get; set; }
        public string WorkshopName { get; set; }

        object IEntityDto.Id
        {
            get => Id;
            set => Id = (int)value;
        }
    }

    public class DefectDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BaseLaborCost { get; set; }

        object IEntityDto.Id
        {
            get => Id;
            set => Id = (int)value;
        }
    }

    public class PartDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public int DefectId { get; set; }
        public int CarId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;
        public string DefectName { get; set; }
        public string CarVin { get; set; }

        object IEntityDto.Id
        {
            get => Id;
            set => Id = (int)value;
        }
    }

    public class PersonnelDto : IEntityDto<string>
    {
        public string Id { get; set; }
        public int WorkshopId { get; set; }
        public int? BrigadeId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public DateTime HiredAt { get; set; }
        public string WorkshopName { get; set; }
        public string BrigadeName { get; set; }

        object IEntityDto.Id
        {
            get => Id;
            set => Id = (string)value;
        }
    }

    public class RepairDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DefectId { get; set; }
        public int BrigadeId { get; set; }
        public DateTime ReceivedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public decimal LaborCost { get; set; }
        public decimal PartsCost { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; }
        public string CarVin { get; set; }
        public string DefectName { get; set; }
        public string BrigadeName { get; set; }
        public string WorkshopName { get; set; }

        object IEntityDto.Id
        {
            get => Id;
            set => Id = (int)value;
        }
    }

    public class WorkshopDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public int BrigadeCount { get; set; }
        public int PersonnelCount { get; set; }

        object IEntityDto.Id
        {
            get => Id;
            set => Id = (int)value;
        }
    }
}