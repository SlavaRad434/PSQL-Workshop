using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Mapper;

using System.ComponentModel;

namespace Workshop.DTO
{
    public class CarDto : IEntityDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("VIN код")]
        public string Vin { get; set; }

        [DisplayName("Номер кузова")]
        public string BodyNumber { get; set; }

        [DisplayName("Номер двигателя")]
        public string EngineNumber { get; set; }

        [DisplayName("Имя владельца")]
        public string OwnerName { get; set; }

        [DisplayName("Телефон владельца")]
        public string OwnerPhone { get; set; }

        public CarDto() { }
    }
}
