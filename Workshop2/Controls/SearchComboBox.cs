using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop2.Controls
{
    public class SearchComboBox : ComboBox
    {
        private List<object> _fullList = new List<object>();
        private string _displayProperty;
        private string _valueProperty;

        public void SetData<T>(IEnumerable<T> data, string displayMember, string valueMember)
        {
            _fullList = data.Cast<object>().ToList();
            _displayProperty = displayMember;
            _valueProperty = valueMember;

            DataSource = null;
            DisplayMember = displayMember;
            ValueMember = valueMember;
            DataSource = _fullList;
        }

        protected override void OnTextUpdate(EventArgs e)
        {
            string term = Text.ToLower();

            var filtered = _fullList
                .Where(x =>
                    x.GetType().GetProperty(_displayProperty)
                    .GetValue(x).ToString().ToLower().Contains(term))
                .ToList();

            var currentText = Text;

            DataSource = null;
            DisplayMember = _displayProperty;
            ValueMember = _valueProperty;
            DataSource = filtered;

            DroppedDown = true;
            Text = currentText;
            SelectionStart = Text.Length;
        }
    }

    // Можно добавить события, например RequestLoad, чтобы родитель загружал данные при вводе
}
