using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Workshop2.Data;
using Workshop2.Models;

namespace Workshop2.Forms
{
    public partial class PartEditForm : Form
    {
        private Part _part;
        private readonly bool _isNew;

        public PartEditForm(Defect defect)
        {
            InitializeComponent();
            _part = new Part
            {
                Defect = defect,
                DefectId = defect.DefectId
            };
            _isNew = true;
            LoadLookups();
            LoadData();
        }


        public PartEditForm(Part part = null)
        {
            LoadLookups();
            InitializeComponent();
            _isNew = part == null;
            _part = part ?? new Part();

            LoadData();
        }

        void LoadData()
        {
            if (_isNew)
            {
                // Для нового дефекта (DefectId = 0) выбираем по объекту
                if (_part.DefectId == 0)
                {
                    cbDefect.SelectedItem = cbDefect.Items
                        .Cast<Defect>()
                        .FirstOrDefault(d => d.Name == _part.Defect.Name);
                }
                else
                {
                    cbDefect.SelectedValue = _part.DefectId;
                }
                return;
            }
            cbDefect.SelectedValue = _part.DefectId;
            tbName.Text = _part.Name;
            nudUnitPrice.Value = _part.UnitPrice;
            nudQuantity.Value = _part.Quantity;

        }
        private void LoadLookups()
        {
            using (var db = new AutoRepairContext())
            {
                var defects = db.Defects.OrderBy(d => d.Name).ToList();
                cbDefect.SetData(defects, "Name", "DefectId");
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            _part.DefectId = (int)cbDefect.SelectedValue;
            _part.Name = tbName.Text.Trim();
            _part.UnitPrice = nudUnitPrice.Value;
            _part.Quantity = (int)nudQuantity.Value;

            using (var db = new AutoRepairContext())
            {
                if (_isNew)
                {
                    db.Parts.Add(_part);
                }
                else
                {
                    db.Parts.Attach(_part);
                    db.Entry(_part).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
