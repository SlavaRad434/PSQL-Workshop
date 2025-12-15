using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop2.Data;
using Workshop2.Models;

namespace Workshop2.Forms
{
    public partial class CarEditForm : Form
    {
        private Car _car;
        public int CreatedCarId { get; private set; }


        public CarEditForm(Car car = null)
        {
            InitializeComponent();
            if (car != null)
            {
               // button1.Enabled = true;
            }
            else
            {
              //  button1.Enabled = false;
            }
            _car = car ?? new Car();
            LoadData();
        }


        private void LoadData()
        {
            if (_car == null) return;
            txtVin.Text = _car.Vin;
            txtBody.Text = _car.BodyNumber;
            txtEngine.Text = _car.EngineNumber;
            txtOwner.Text = _car.OwnerName;
            txtPhone.Text = _car.OwnerPhone;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new AutoRepairContext())
            {




                _car.Vin = txtVin.Text.Trim();
                _car.BodyNumber = txtBody.Text.Trim();
                _car.EngineNumber = txtEngine.Text.Trim();
                _car.OwnerName = txtOwner.Text.Trim();
                _car.OwnerPhone = txtPhone.Text.Trim();


                db.SaveChanges();
                CreatedCarId = _car.CarId;
            }


            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (_car.CarId == 0)
                {
                    MessageBox.Show("Несуществующий автомобиль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show(
                    "Вы действительно хотите завершить ремонт?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;
            using (var db = new AutoRepairContext())
            {
                db.Cars.Remove(db.Cars.Find(_car.Vin));
                db.SaveChanges();
            }
        }
    }
}
