using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Workshop2.Data;
using Workshop2.Models;

namespace Workshop2.Forms
{
    public partial class DefectEditForm : Form
    {
        private Defect _defect;
        private bool _isNew;

        public int CreatedDefectId { get; private set; }

        public DefectEditForm(Defect defect = null)
        {
            InitializeComponent();

            _isNew = defect == null;
            _defect = defect ?? new Defect();

            LoadData();
            LoadParts();
        }

        // -------------------------------
        // Загрузка данных в форму
        // -------------------------------
        private void LoadData()
        {
            txtName.Text = _defect.Name ?? "";
            numLabor.Value = _defect.BaseLaborCost;
        }

        // -------------------------------
        // Загрузка списка деталей
        // -------------------------------
        private void LoadParts()
        {
            using (var db = new AutoRepairContext())
            {
                // Выбираем только нужные поля, включая название дефекта
                var parts = db.Parts
                    .Where(p => p.DefectId == _defect.DefectId)
                    .Select(p => new
                    {
                        p.PartId,
                        p.Name,
                        p.UnitPrice,
                        p.Quantity,
                        DefectName = p.Defect.Name  // сразу вытягиваем имя дефекта
                    })
                    .ToList();

                // Назначаем DataSource
                gridParts.DataSource = parts;

                // Опционально: задаём понятные заголовки колонок
                if (gridParts.Columns["PartId"] != null)
                    gridParts.Columns["PartId"].HeaderText = "ID";
                if (gridParts.Columns["Name"] != null)
                    gridParts.Columns["Name"].HeaderText = "Название детали";
                if (gridParts.Columns["UnitPrice"] != null)
                    gridParts.Columns["UnitPrice"].HeaderText = "Цена за единицу";
                if (gridParts.Columns["Quantity"] != null)
                    gridParts.Columns["Quantity"].HeaderText = "Количество";
                if (gridParts.Columns["DefectName"] != null)
                    gridParts.Columns["DefectName"].HeaderText = "Неисправность";
            }
        }


        // -------------------------------
        // Автосохранение дефекта, если новый
        // -------------------------------
        private bool EnsureDefectSaved()
        {
            if (_defect.DefectId != 0)
                return true;

            try
            {
                using (var db = new AutoRepairContext())
                {
                    _defect.Name = txtName.Text.Trim();
                    _defect.BaseLaborCost = numLabor.Value;
                    db.Defects.Add(_defect);
                    db.SaveChanges();
                }

                //_isNew = false;
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                string msg = "";
                foreach (var ve in ex.EntityValidationErrors)
                {
                    msg += $"ENTITY: {ve.Entry.Entity.GetType().Name}\n";
                    foreach (var err in ve.ValidationErrors)
                    {
                        msg += $" - {err.PropertyName}: {err.ErrorMessage}\n";
                    }
                }

                MessageBox.Show("Ошибка валидации:\n" + msg);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения неисправности:\n" +
                    (ex.InnerException?.Message ?? ex.Message));
                return false;
            }
        }

        // -------------------------------
        // Добавление детали
        // -------------------------------
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (!EnsureDefectSaved())
                return;

            using (var f = new PartEditForm(_defect))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadParts();
                }
            }
        }

        // -------------------------------
        // Сохранение формы
        // -------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AutoRepairContext())
                {
                    if (_defect.DefectId == 0)
                        db.Defects.Add(_defect);
                    else
                        db.Defects.Attach(_defect);

                    _defect.Name = txtName.Text.Trim();
                    _defect.BaseLaborCost = numLabor.Value;

                    db.SaveChanges();
                    CreatedDefectId = _defect.DefectId;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения:\n" +
                    (ex.InnerException?.Message ?? ex.Message));
            }
        }

        // -------------------------------
        // Отмена – откат всех данных
        // -------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_isNew && _defect.DefectId != 0)
            {
                // Удаляем несохранённый дефект и его детали
                using (var db = new AutoRepairContext())
                {
                    var parts = db.Parts.Where(p => p.DefectId == _defect.DefectId);
                    db.Parts.RemoveRange(parts);

                    db.Defects.Remove(db.Defects.Find(_defect.DefectId));

                    db.SaveChanges();
                }
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
