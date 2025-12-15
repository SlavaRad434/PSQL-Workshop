using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Workshop2.Data;

namespace Workshop2.Forms
{
    public partial class UniversalGridForm : Form
    {
        private readonly Func<AutoRepairContext, IEnumerable<object>> _loadFunc;

        public UniversalGridForm(Func<AutoRepairContext, IEnumerable<object>> loadFunc, string title)
        {
            InitializeComponent();
            _loadFunc = loadFunc;
            this.Text = title;
        }

        private void UniversalGridForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new AutoRepairContext())
            {
                var data = _loadFunc(db).ToList();
                dgv.DataSource = data;
            }

            dgv.AutoResizeColumns();
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
        }
    }
}
