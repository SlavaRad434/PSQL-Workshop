//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.Entity;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml.Linq;
//using Workshop2.Data;
//using Workshop2.Models;

//namespace Workshop2.Forms
//{
//    public partial class DefectEditForm : Form
//    {
//        private Defect _defect;
//        private readonly bool _isNew;

//        public int CarId { get; set; }  // <-- Важно! Приходит из RepairEditForm

//        public DefectEditForm()
//        {
//            InitializeComponent();
//            //CarId = carId;

//            _defect = new Defect();
//            _isNew = true;
//        }

//        public DefectEditForm(Defect defect)
//        {
//            InitializeComponent();
//            //CarId = carId;

//            _defect = defect;
//            _isNew = false;

//            tbName.Text = _defect.Name;
//            nudBaseLaborCost.Value = _defect.BaseLaborCost;

//            LoadParts();
//        }

//        private void LoadParts()
//        {
//            using (var db = new AutoRepairContext())
//            {
//                var parts = db.Parts
//                    .Where(p => p.DefectId == _defect.DefectId)
//                    .Select(p => new
//                    {
//                        p.PartId,
//                        p.Name,
//                        p.UnitPrice,
//                        p.Quantity,
//                        Sum = p.UnitPrice * p.Quantity
//                    })
//                    .ToList();

//                dgvParts.DataSource = parts;
//            }
//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            _defect.Name = tbName.Text.Trim();
//            _defect.BaseLaborCost = nudBaseLaborCost.Value;

//            using (var db = new AutoRepairContext())
//            {
//                if (_isNew)
//                {
//                    db.Defects.Add(_defect);
//                    db.SaveChanges(); // <-- Defect получает DefectId
//                }
//                else
//                {
//                    db.Entry(_defect).State = EntityState.Modified;
//                    db.SaveChanges();
//                }
//            }

//            MessageBox.Show("Неисправность сохранена.", "Успех");

//            // теперь можно добавлять детали
//            btnAddPart.Enabled = true;

//            DialogResult = DialogResult.OK;
//        }

//        private void btnAddPart_Click(object sender, EventArgs e)
//        {
//            if (_isNew || _defect.DefectId == 0)
//            {
//                MessageBox.Show("Сначала сохраните неисправность.");
//                return;
//            }

//            var form = new PartEditForm(_defect.DefectId, CarId);

//            if (form.ShowDialog() == DialogResult.OK)
//            {
//                LoadParts();
//            }
//        }
//    }

//}
