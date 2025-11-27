using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DTO;
using Workshop.Models;
using Workshop.Services;

namespace Workshop.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnCars_Click(object sender, EventArgs e)
        {
            using (var db = new AutoRepairContext())
            {
                var service = new CarService(db);
                var gridForm = new EntityGridForm<Car, CarDto>(service);
                gridForm.ShowDialog();
            }
        }



        //private void btnCars_Click(object sender, EventArgs e)
        //{
        //    using (var db = new AutoRepairContext())
        //    {
        //        // Получаем данные и мапим их в DTO
        //        var cars = db.Cars.Select(c => new CarDto
        //        {
        //            Id = c.CarId,
        //            VIN = c.Vin,
        //            Body = c.BodyNumber,
        //            Engine = c.EngineNumber,
        //            Owner = c.OwnerName,
        //            Phone = c.OwnerPhone
        //        }).ToList();

        //        // Создаём универсальную форму EntityGridForm<CarDto>
        //        var form = new EntityGridForm<CarDto>(
        //            cars,
        //            addItem: car =>
        //            {
        //                // Добавление нового автомобиля
        //                var entity = new Car
        //                {
        //                    Vin = car.VIN,
        //                    BodyNumber = car.Body,
        //                    EngineNumber = car.Engine,
        //                    OwnerName = car.Owner,
        //                    OwnerPhone = car.Phone
        //                };
        //                db.Cars.Add(entity);
        //                db.SaveChanges();

        //                car.Id = entity.CarId; // обновляем Id в DTO
        //            },
        //            updateItem: car =>
        //            {
        //                // Редактирование
        //                var entity = db.Cars.Find(car.Id);
        //                if (entity != null)
        //                {
        //                    entity.Vin = car.VIN;
        //                    entity.BodyNumber = car.Body;
        //                    entity.EngineNumber = car.Engine;
        //                    entity.OwnerName = car.Owner;
        //                    entity.OwnerPhone = car.Phone;
        //                    db.SaveChanges();
        //                }
        //            },
        //            deleteItem: car =>
        //            {
        //                // Удаление
        //                var entity = db.Cars.Find(car.Id);
        //                if (entity != null)
        //                {
        //                    db.Cars.Remove(entity);
        //                    db.SaveChanges();
        //                }
        //            }
        //        );

        //        form.ShowDialog(); // показываем форму
        //    }
        //}


    }
}
