using Workshop2.Controls;

namespace Workshop2.Forms
{
    partial class PersonalEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbInn;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.DateTimePicker dtHired;
        private SearchComboBox cbBrigade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInn;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.Label lblBrigade;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbInn = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.dtHired = new System.Windows.Forms.DateTimePicker();
            this.cbBrigade = new Workshop2.Controls.SearchComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInn = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblHired = new System.Windows.Forms.Label();
            this.lblBrigade = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // Labels
            // 
            this.lblInn.Text = "ИНН";
            this.lblInn.Location = new System.Drawing.Point(12, 15);
            this.lblFullName.Text = "ФИО";
            this.lblFullName.Location = new System.Drawing.Point(12, 45);
            this.lblRole.Text = "Должность";
            this.lblRole.Location = new System.Drawing.Point(12, 75);
            this.lblHired.Text = "Дата найма";
            this.lblHired.Location = new System.Drawing.Point(12, 105);
            this.lblBrigade.Text = "Бригада";
            this.lblBrigade.Location = new System.Drawing.Point(12, 135);

            // 
            // tbInn
            // 
            this.tbInn.Location = new System.Drawing.Point(120, 12);
            this.tbInn.Size = new System.Drawing.Size(200, 20);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(120, 42);
            this.tbFullName.Size = new System.Drawing.Size(200, 20);
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(120, 72);
            this.tbRole.Size = new System.Drawing.Size(200, 20);
            // 
            // dtHired
            // 
            this.dtHired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHired.Location = new System.Drawing.Point(120, 102);
            this.dtHired.Size = new System.Drawing.Size(200, 20);
            // 
            // cbBrigade
            // 
            this.cbBrigade.Location = new System.Drawing.Point(120, 132);
            this.cbBrigade.Size = new System.Drawing.Size(200, 21);
            // 
            // btnSave
            // 
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(12, 170);
            this.btnSave.Size = new System.Drawing.Size(140, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Location = new System.Drawing.Point(180, 170);
            this.btnCancel.Size = new System.Drawing.Size(140, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // PersonalEditForm
            // 
            this.ClientSize = new System.Drawing.Size(340, 220);
            this.Controls.Add(this.tbInn);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.tbRole);
            this.Controls.Add(this.dtHired);
            this.Controls.Add(this.cbBrigade);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInn);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblHired);
            this.Controls.Add(this.lblBrigade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
           // this.Text = _isNew ? "Новый сотрудник" : "Редактировать сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
