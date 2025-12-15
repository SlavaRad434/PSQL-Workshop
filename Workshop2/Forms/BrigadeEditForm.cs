using System;
using System.Linq;
using System.Windows.Forms;
using Workshop2.Data;
using Workshop2.Models;
using Workshop2.Controls;

namespace Workshop2.Forms
{
    public partial class BrigadeEditForm : Form
    {
        private Brigade _brigade;
        private bool _isNew;

        public int CreatedBrigadeId { get; private set; }

        public BrigadeEditForm(Brigade brigade = null)
        {
            InitializeComponent();

            _isNew = brigade == null;
            _brigade = brigade ?? new Brigade();

            LoadLookups();
            LoadData();
            LoadPersonnel();
        }

        // -------------------------------
        // Загрузка данных бригады
        // -------------------------------
        private void LoadData()
        {
            txtName.Text = _brigade.Name ?? "";
            if (_brigade.WorkshopId != 0)
                cbWorkshop.SelectedValue = _brigade.WorkshopId;
            else
                cbWorkshop.SelectedIndex = -1;
        }

        // -------------------------------
        // Загрузка сотрудников бригады
        // -------------------------------
        private void LoadPersonnel()
        {
            if (_brigade.BrigadeId == 0)
            {
                gridPersonnel.DataSource = null;
                return;
            }

            using (var db = new AutoRepairContext())
            {
                var personnel = db.Personnel
                    .Where(p => p.BrigadeId == _brigade.BrigadeId)
                    .Select(p => new
                    {
                        p.PersonInn,
                        p.FullName,
                        p.Role,
                        p.HiredAt   // выбираем как DateTime
                    })
                    .ToList()   // данные извлекаются в память
                    .Select(p => new
                    {
                        p.PersonInn,
                        p.FullName,
                        p.Role,
                        HiredAt = p.HiredAt.ToShortDateString() // форматируем уже в памяти
                    })
                    .ToList();

                gridPersonnel.DataSource = personnel;
            


            if (gridPersonnel.Columns["PersonInn"] != null)
                    gridPersonnel.Columns["PersonInn"].HeaderText = "ИНН";
                if (gridPersonnel.Columns["FullName"] != null)
                    gridPersonnel.Columns["FullName"].HeaderText = "ФИО";
                if (gridPersonnel.Columns["Role"] != null)
                    gridPersonnel.Columns["Role"].HeaderText = "Должность";
                if (gridPersonnel.Columns["HiredAt"] != null)
                    gridPersonnel.Columns["HiredAt"].HeaderText = "Дата найма";
            }
        }

        // -------------------------------
        // Загрузка справочников
        // -------------------------------
        private void LoadLookups()
        {
            using (var db = new AutoRepairContext())
            {
                var workshops = db.Workshops.OrderBy(w => w.Name).ToList();
                cbWorkshop.SetData(workshops, "Name", "WorkshopId");
                cbWorkshop.SelectedIndex = -1;
            }
        }

        // -------------------------------
        // Добавление нового сотрудника
        // -------------------------------
        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            if (!EnsureBrigadeSaved())
                return;

            using (var f = new PersonalEditForm(_brigade))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadPersonnel();
                }
            }
        }

        // -------------------------------
        // Сохранение бригады
        // -------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbWorkshop.SelectedItem == null)
            {
                MessageBox.Show("Выберите мастерскую.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AutoRepairContext())
                {
                    if (_brigade.BrigadeId == 0)
                        db.Brigades.Add(_brigade);
                    else
                        db.Brigades.Attach(_brigade);

                    _brigade.Name = txtName.Text.Trim();
                    _brigade.WorkshopId = (int)cbWorkshop.SelectedValue;

                    db.SaveChanges();
                    CreatedBrigadeId = _brigade.BrigadeId;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения:\n" + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        // -------------------------------
        // Отмена
        // -------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // -------------------------------
        // Автосохранение новой бригады перед добавлением сотрудника
        // -------------------------------
        private bool EnsureBrigadeSaved()
        {
            if (_brigade.BrigadeId != 0)
                return true;

            if (cbWorkshop.SelectedItem == null)
            {
                MessageBox.Show("Выберите мастерскую перед сохранением бригады.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (var db = new AutoRepairContext())
                {
                    _brigade.Name = txtName.Text.Trim();
                    _brigade.WorkshopId = (int)cbWorkshop.SelectedValue;
                    db.Brigades.Add(_brigade);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения бригады:\n" + (ex.InnerException?.Message ?? ex.Message));
                return false;
            }
        }
    }
}
