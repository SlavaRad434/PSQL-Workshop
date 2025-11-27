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

namespace Workshop.Forms
{
    public partial class CarsControl : UserControl
    {
        private AutoRepairContext db = new AutoRepairContext();

        public CarsControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var cars = db.Cars
    .Select(c => new CarDto
    {
        Id = c.CarId,
        VIN = c.Vin,
        Body = c.BodyNumber,
        Engine = c.EngineNumber,
        Owner = c.OwnerName,
        Phone = c.OwnerPhone
    })
    .ToList();

            dataGridViewCars.DataSource = cars;
            

            // Добавляем колонку с кнопкой "Ремонты"
            var repairsButton = new DataGridViewButtonColumn();
            repairsButton.HeaderText = "Ремонты";
            repairsButton.Text = "Открыть";
            repairsButton.UseColumnTextForButtonValue = true;
            repairsButton.Name = "RepairsButton";
            dataGridViewCars.Columns.Add(repairsButton);

            // Добавляем колонку с кнопкой "Запчасти"
            var partsButton = new DataGridViewButtonColumn();
            partsButton.HeaderText = "Запчасти";
            partsButton.Text = "Открыть";
            partsButton.UseColumnTextForButtonValue = true;
            partsButton.Name = "PartsButton";
            dataGridViewCars.Columns.Add(partsButton);
        }
        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // заголовок

            int carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells["Id"].Value;

            if (dataGridViewCars.Columns[e.ColumnIndex].Name == "RepairsButton")
                OpenRepairs(carId);

            if (dataGridViewCars.Columns[e.ColumnIndex].Name == "PartsButton")
                OpenParts(carId);
        }

        private void OpenRepairs(int carId)
        {
            //var form = new RepairsForm(carId);
            //form.Show();
        }

        private void OpenParts(int carId)
        {
            //var form = new PartsForm(carId);
            //form.Show();
        }



        // кнопки Add, Delete, Update здесь
    }
}
