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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadRepairs();
        }

        private void LoadRepairs()
        {
            try
            {
                using (var db = new AutoRepairContext())
                {
                    var data = db.Repairs
                        .Where(r => r.Status != "завершён" && r.Status != "завершено")
                        .Select(r => new
                        {
                            r.RepairId,
                            VIN = r.Car.Vin,
                            Defect = r.Defect.Name,
                            Brigade = r.Brigade.Name,
                            Received = r.ReceivedAt,
                            Total = r.LaborCost,
                            Status = r.Status
                        })
                        .ToList();

                    dgvRepairs.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД:\n" +
                    (ex.InnerException?.Message ?? ex.Message));
            }
            dgvRepairs.Columns["RepairId"].HeaderText = "ID";
            dgvRepairs.Columns["VIN"].HeaderText = "VIN";
            dgvRepairs.Columns["Defect"].HeaderText = "Неисправность";
            dgvRepairs.Columns["Brigade"].HeaderText = "Бригада";
            dgvRepairs.Columns["Received"].HeaderText = "Принят";
            dgvRepairs.Columns["Total"].HeaderText = "Стоимость";
            dgvRepairs.Columns["Status"].HeaderText = "Статус";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRepairs.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.", "Нет выбора",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int repairId = (int)dgvRepairs.CurrentRow.Cells["RepairId"].Value;

            using (var editForm = new RepairEditForm(repairId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadRepairs(); // обновить таблицу
                }
            }
        }

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            using (var f = new RepairEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    LoadRepairs();
            }
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (dgvRepairs.CurrentRow == null)
            {
                MessageBox.Show("Ремонт не загружен.", "Ошибка",
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
                // Загружаем актуальную версию объекта из БД
                int id = (int)dgvRepairs.CurrentRow.Cells["RepairId"].Value;
                var repair = db.Repairs.FirstOrDefault(r => r.RepairId == id);

                if (repair == null)
                {
                    MessageBox.Show("Ремонт не найден в базе данных.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Изменяем поля
                repair.Status = "завершён";
                repair.FinishedAt = DateTime.Today;

                db.Entry(repair).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            MessageBox.Show("Ремонт успешно завершён!", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRepairs();
        }

        private void btnBrigade(object sender, EventArgs e)
        {
            var f = new UniversalGridForm(
                db => db.BrigadePerformance.OrderBy(b => b.Brigade),
                "Производительность бригад"
                    );
            f.Show();
        }

        // Список автомобилей
        private void btnCar(object sender, EventArgs e)
        {
            var f = new UniversalGridForm(
            db => db.CarsView.OrderBy(c => c.Vin),
            "Автомобили"
        );
            f.Show();
        }

        // Стоимость ремонта
        private void btnCost(object sender, EventArgs e)
        {
            var f = new UniversalGridForm(
            db => db.RepairCostView.OrderBy(r => r.RepairId),
            "Стоимость ремонта"
        );
            f.Show();
        }

        // Подробные ремонты
        private void btnDetailed(object sender, EventArgs e)
        {
            var f = new UniversalGridForm(
            db => db.RepairDetailedView.OrderBy(r => r.RepairId),
            "Подробные ремонты"
        );
            f.Show();
        }

        private void btnAddPersonal_Click(object sender, EventArgs e)
        {
            using (var form = new PersonalEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK) ;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRepairs.CurrentRow == null)
            {
                MessageBox.Show("Ремонт не загружен.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                "Вы действительно хотите удалить ремонт?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using (var db = new AutoRepairContext())
            {
                // Загружаем актуальную версию объекта из БД
                int id = (int)dgvRepairs.CurrentRow.Cells["RepairId"].Value;
                var repair = db.Repairs.FirstOrDefault(r => r.RepairId == id);

                if (repair == null)
                {
                    MessageBox.Show("Ремонт не найден в базе данных.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Изменяем поля
                db.Repairs.Remove(db.Repairs.Find(id));

                db.SaveChanges();
            }

            MessageBox.Show("Ремонт удален!", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
