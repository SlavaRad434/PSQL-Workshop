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
    public partial class WorkshopEditForm : Form
    {
        public int CreatedWorkshopId { get; private set; }

        public WorkshopEditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new AutoRepairContext())
            {
                var workshop = new Workshop
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text
                };

                db.Workshops.Add(workshop);
                db.SaveChanges();

                CreatedWorkshopId = workshop.WorkshopId;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
    