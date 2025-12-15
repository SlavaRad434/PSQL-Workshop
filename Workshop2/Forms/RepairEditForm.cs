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
using Workshop2.Controls;

namespace Workshop2.Forms
{
    
    public partial class RepairEditForm : Form
    {
        private Repair _repair;
        private bool _isNew;
        public RepairEditForm(Repair repair = null)
        {
            InitializeComponent();
            LoadLookups();
            _isNew = repair == null;
            _repair = repair ?? new Repair();
            LoadData();
        }
        public RepairEditForm(int repairId)
        {
            InitializeComponent();
            LoadLookups();
            _repair = LoadRepair(repairId);
            LoadData();
        }
        private void LoadData()
        {
            cbStatus.Items.AddRange(new[] { "в процессе", "ожидает запчастей", "завершён" });
            if (_isNew) return;
            cbCar.SelectedValue = _repair.CarId;
            cbDefect.SelectedValue = _repair.DefectId;
            cbBrigade.SelectedValue = _repair.BrigadeId;
            dtReceived.Value = _repair.ReceivedAt;
            //dtpFinished.Value = _repair.FinishedAt ?? DateTime.Today;
            nudLabor.Value = _repair.LaborCost;
            // nudPartsCost.Value = _repair.PartsCost;
            //nudTotalCost.Value = _repair.TotalCost;
            cbStatus.Text = _repair.Status;
            cbStatus.SelectedIndex = 0;
        }

        private Repair LoadRepair(int repairId)
        {
            using (var db = new AutoRepairContext())
            {
                var _repair = db.Repairs
                    .Include("Car")
                    .Include("Defect")
                    .Include("Brigade")
                    .FirstOrDefault(r => r.RepairId == repairId);


                if (_repair == null)
                {
                    MessageBox.Show("Ремонт не найден.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return null;
                }
                return _repair;
            }
        }
        private void LoadCars()
        {
            using (var db = new AutoRepairContext())
            {
                var cars = db.Cars.OrderBy(c => c.Vin).ToList();
                cbCar.SetData(cars, "Vin", "CarId");
            }
        }

        private void LoadDefects()
        {
            using (var db = new AutoRepairContext())
            {
                var defects = db.Defects.OrderBy(d => d.Name).ToList();
                cbDefect.SetData(defects, "Name", "DefectId");
            }
        }

        private void LoadBrigades()
        {
            using (var db = new AutoRepairContext())
            {
                var brigades = db.Brigades.OrderBy(b => b.Name).ToList();
                cbBrigade.SetData(brigades, "Name", "BrigadeId");
            }
        }

        private void LoadLookups()
        {
            using (var db = new AutoRepairContext())
            {
                // Машины
                var cars = db.Cars.OrderBy(c => c.Vin).ToList();
                cbCar.SetData(cars, "Vin", "CarId");

                // Неисправности
                var defects = db.Defects.OrderBy(d => d.Name).ToList();
                cbDefect.SetData(defects, "Name", "DefectId");

                // Бригады
                var brigades = db.Brigades.OrderBy(b => b.Name).ToList();
                cbBrigade.SetData(brigades, "Name", "BrigadeId");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCar.SelectedItem == null || cbDefect.SelectedItem == null || cbBrigade.SelectedItem == null)
            {
                MessageBox.Show("Выберите автомобиль, неисправность и бригаду.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AutoRepairContext())
            {
                if (_repair == null)
                {
                    _repair = new Repair
                    {
                        CarId = (int)cbCar.SelectedValue,
                        DefectId = (int)cbDefect.SelectedValue,
                        BrigadeId = (int)cbBrigade.SelectedValue,
                        ReceivedAt = dtReceived.Value.Date,
                        LaborCost = nudLabor.Value,
                        Status = cbStatus.Text
                    };
                    db.Repairs.Add(_repair);
                }
                else
                {
                    _repair.CarId = (int)cbCar.SelectedValue;
                    _repair.DefectId = (int)cbDefect.SelectedValue;
                    _repair.BrigadeId = (int)cbBrigade.SelectedValue;
                    _repair.ReceivedAt = dtReceived.Value.Date;
                    _repair.LaborCost = nudLabor.Value;
                    _repair.Status = cbStatus.Text;
                    db.Entry(_repair).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            using (var f = new CarEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadLookups();
                    cbCar.SelectedValue = f.CreatedCarId;
                }
            }
        }

        private void btnAddDefect_Click(object sender, EventArgs e)
        {
            using (var f = new DefectEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadLookups();
                    cbDefect.SelectedValue = f.CreatedDefectId;
                }
            }
        }

        private void btnAddBrigade_Click(object sender, EventArgs e)
        {
            using (var f = new BrigadeEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadLookups();
                    cbBrigade.SelectedValue = f.CreatedBrigadeId;
                }
            }
        }

        private void cbBrigade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditBrigade_Click(object sender, EventArgs e)
        {
                if (cbBrigade.SelectedItem is Brigade selected)
            {
                using (var f = new BrigadeEditForm(selected))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        ReloadBrigades(selected.BrigadeId);
                    }
                }
            }
        }
        private void ReloadBrigades(int selectId)
        {
            using (var db = new AutoRepairContext())
            {
                cbBrigade.DataSource = db.Brigades.OrderBy(b => b.Name).ToList();
            }

            cbBrigade.SelectedValue = selectId;
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (cbCar.SelectedItem is Car selected)
            {
                using (var f = new CarEditForm(selected))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        ReloadCars(selected.CarId);
                    }
                }
            }
        }
        private void ReloadCars(int selectId)
        {
            using (var db = new AutoRepairContext())
            {
                cbCar.DataSource = db.Cars.OrderBy(c => c.Vin).ToList();
            }

            cbCar.SelectedValue = selectId;
        }

        private void btnEditDefect_Click(object sender, EventArgs e)
        {
            if (cbDefect.SelectedItem is Defect selected)
            {
                using (var f = new DefectEditForm(selected))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        ReloadDefects(selected.DefectId);
                    }
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите неисправность.");
            }
        }
        private void ReloadDefects(int selectId)
        {
            using (var db = new AutoRepairContext())
            {
                cbDefect.DataSource = db.Defects.OrderBy(d => d.Name).ToList();
            }

            cbDefect.SelectedValue = selectId;
        }
    }
}
