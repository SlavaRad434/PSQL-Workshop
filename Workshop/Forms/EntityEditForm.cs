using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Workshop.DTO;

namespace Workshop.Forms
{
    public partial class EntityEditForm<T> : Form
    where T : class, IEntityDto, new()
    {
        private readonly T _entity;
        private readonly Dictionary<PropertyInfo, Control> _controls
            = new Dictionary<PropertyInfo, Control>();

        public EntityEditForm(T entity)
        {
            InitializeComponent();
            _entity = entity;
            BuildForm();
        }

        private void BuildForm()
        {
            Text = $"Edit {typeof(T).Name}";
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            var panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                AutoSize = true
            };

            int row = 0;

            foreach (var prop in typeof(T).GetProperties()
                         .Where(p => p.CanRead && p.CanWrite))
            {
                if (prop.Name == "Id") continue; // 🔒 скрываем Id

                panel.Controls.Add(new Label
                {
                    Text = prop.Name,
                    AutoSize = true
                }, 0, row);

                var tb = new TextBox
                {
                    Width = 200,
                    Text = prop.GetValue(_entity)?.ToString() ?? ""
                };

                _controls[prop] = tb;
                panel.Controls.Add(tb, 1, row);
                row++;
            }

            var btnSave = new Button { Text = "Save", AutoSize = true };
            btnSave.Click += BtnSave_Click;

            panel.Controls.Add(btnSave, 1, row);
            Controls.Add(panel);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            foreach (var kvp in _controls)
            {
                var prop = kvp.Key;
                var ctrl = kvp.Value;

                if (prop.PropertyType == typeof(string))
                    prop.SetValue(_entity, ctrl.Text);

                else if (prop.PropertyType == typeof(int))
                    prop.SetValue(_entity, int.TryParse(ctrl.Text, out var v) ? v : 0);

                else if (prop.PropertyType == typeof(decimal))
                    prop.SetValue(_entity, decimal.TryParse(ctrl.Text, out var d) ? d : 0);
            }


            DialogResult = DialogResult.OK;
            Close();
        }
    }
}