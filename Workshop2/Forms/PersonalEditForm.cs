using System;
using System.Linq;
using System.Windows.Forms;
using Workshop2.Controls;
using Workshop2.Data;
using Workshop2.Models;

namespace Workshop2.Forms
{
    public partial class PersonalEditForm : Form
    {
        private Personnel _personnel;
        private bool _isNew;


        public PersonalEditForm(Brigade brigade)
        {
            InitializeComponent();

            _isNew = true; // всегда создаём нового сотрудника
            _personnel = new Personnel
            {
                Brigade = brigade,
                BrigadeId = brigade.BrigadeId
            };

            LoadLookups();
            LoadData();
        }

        public PersonalEditForm(Personnel personnel = null)
        {
            InitializeComponent();

            _isNew = personnel == null;
            _personnel = personnel ?? new Personnel();

            LoadLookups();
            LoadData();
        }

        private void LoadData()
        {
            if (!_isNew)
            {
                tbInn.Text = _personnel.PersonInn;
                tbFullName.Text = _personnel.FullName;
                tbRole.Text = _personnel.Role;
                dtHired.Value = _personnel.HiredAt;

                if (_personnel.BrigadeId.HasValue)
                    cbBrigade.SelectedValue = _personnel.BrigadeId.Value;
                else
                    cbBrigade.SelectedIndex = -1;
            }
        }

        private void LoadLookups()
        {
            using (var db = new AutoRepairContext())
            {
                var brigades = db.Brigades.OrderBy(b => b.Name).ToList();
                cbBrigade.SetData(brigades, "Name", "BrigadeId");
                cbBrigade.SelectedIndex = -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbInn.Text))
            {
                MessageBox.Show("Введите ИНН сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                MessageBox.Show("Введите ФИО сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _personnel.PersonInn = tbInn.Text.Trim();
            _personnel.FullName = tbFullName.Text.Trim();
            _personnel.Role = tbRole.Text.Trim();
            _personnel.HiredAt = dtHired.Value;
            _personnel.BrigadeId = cbBrigade.SelectedValue as int?;

            using (var db = new AutoRepairContext())
            {
                if (_isNew)
                {
                    db.Personnel.Add(_personnel);
                }
                else
                {
                    db.Personnel.Attach(_personnel);
                    db.Entry(_personnel).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
