using System.Windows.Forms;

namespace Workshop2.Forms
{
    partial class PartEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private TextBox tbName;
        private Label lblUnitPrice;
        private NumericUpDown nudUnitPrice;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDefect = new Workshop2.Controls.SearchComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название детали:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(160, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 84);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(130, 25);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Цена за единицу:";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.DecimalPlaces = 2;
            this.nudUnitPrice.Location = new System.Drawing.Point(160, 84);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(200, 20);
            this.nudUnitPrice.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(20, 110);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(130, 25);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Количество:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(160, 110);
            this.nudQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(200, 20);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(340, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Неисправность:";
            // 
            // cbDefect
            // 
            this.cbDefect.FormattingEnabled = true;
            this.cbDefect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDefect.Location = new System.Drawing.Point(160, 29);
            this.cbDefect.Name = "cbDefect";
            this.cbDefect.Size = new System.Drawing.Size(200, 21);
            this.cbDefect.TabIndex = 9;
            // 
            // PartEditForm
            // 
            this.ClientSize = new System.Drawing.Size(380, 220);
            this.Controls.Add(this.cbDefect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PartEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Деталь";
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label label1;
        private Controls.SearchComboBox cbDefect;
    }
}
