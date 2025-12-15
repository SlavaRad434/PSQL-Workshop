using Workshop2.Controls;

namespace Workshop2.Forms
{
    partial class RepairEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private SearchComboBox cbCar;
        private SearchComboBox cbDefect;
        private SearchComboBox cbBrigade;
        private System.Windows.Forms.DateTimePicker dtReceived;
        private System.Windows.Forms.NumericUpDown nudLabor;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddDefect;
        private System.Windows.Forms.Button btnAddBrigade;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbCar = new Workshop2.Controls.SearchComboBox();
            this.cbDefect = new Workshop2.Controls.SearchComboBox();
            this.cbBrigade = new Workshop2.Controls.SearchComboBox();
            this.dtReceived = new System.Windows.Forms.DateTimePicker();
            this.nudLabor = new System.Windows.Forms.NumericUpDown();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddDefect = new System.Windows.Forms.Button();
            this.btnAddBrigade = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnEditDefect = new System.Windows.Forms.Button();
            this.btnEditBrigade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLabor)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCar
            // 
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(72, 12);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(224, 21);
            this.cbCar.TabIndex = 0;
            // 
            // cbDefect
            // 
            this.cbDefect.FormattingEnabled = true;
            this.cbDefect.Location = new System.Drawing.Point(72, 39);
            this.cbDefect.Name = "cbDefect";
            this.cbDefect.Size = new System.Drawing.Size(224, 21);
            this.cbDefect.TabIndex = 2;
            // 
            // cbBrigade
            // 
            this.cbBrigade.FormattingEnabled = true;
            this.cbBrigade.Location = new System.Drawing.Point(72, 66);
            this.cbBrigade.Name = "cbBrigade";
            this.cbBrigade.Size = new System.Drawing.Size(224, 21);
            this.cbBrigade.TabIndex = 4;
            this.cbBrigade.SelectedIndexChanged += new System.EventHandler(this.cbBrigade_SelectedIndexChanged);
            // 
            // dtReceived
            // 
            this.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReceived.Location = new System.Drawing.Point(117, 93);
            this.dtReceived.Name = "dtReceived";
            this.dtReceived.Size = new System.Drawing.Size(179, 20);
            this.dtReceived.TabIndex = 6;
            // 
            // nudLabor
            // 
            this.nudLabor.DecimalPlaces = 2;
            this.nudLabor.Location = new System.Drawing.Point(117, 119);
            this.nudLabor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLabor.Name = "nudLabor";
            this.nudLabor.Size = new System.Drawing.Size(179, 20);
            this.nudLabor.TabIndex = 7;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(72, 145);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(224, 21);
            this.cbStatus.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(252, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(302, 10);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(34, 23);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "+";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnAddDefect
            // 
            this.btnAddDefect.Location = new System.Drawing.Point(302, 37);
            this.btnAddDefect.Name = "btnAddDefect";
            this.btnAddDefect.Size = new System.Drawing.Size(34, 23);
            this.btnAddDefect.TabIndex = 3;
            this.btnAddDefect.Text = "+";
            this.btnAddDefect.UseVisualStyleBackColor = true;
            this.btnAddDefect.Click += new System.EventHandler(this.btnAddDefect_Click);
            // 
            // btnAddBrigade
            // 
            this.btnAddBrigade.Location = new System.Drawing.Point(302, 66);
            this.btnAddBrigade.Name = "btnAddBrigade";
            this.btnAddBrigade.Size = new System.Drawing.Size(34, 23);
            this.btnAddBrigade.TabIndex = 5;
            this.btnAddBrigade.Text = "+";
            this.btnAddBrigade.UseVisualStyleBackColor = true;
            this.btnAddBrigade.Click += new System.EventHandler(this.btnAddBrigade_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(342, 10);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(34, 23);
            this.btnEditCar.TabIndex = 11;
            this.btnEditCar.Text = "✎";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnEditDefect
            // 
            this.btnEditDefect.Location = new System.Drawing.Point(342, 37);
            this.btnEditDefect.Name = "btnEditDefect";
            this.btnEditDefect.Size = new System.Drawing.Size(34, 23);
            this.btnEditDefect.TabIndex = 12;
            this.btnEditDefect.Text = "✎";
            this.btnEditDefect.UseVisualStyleBackColor = true;
            this.btnEditDefect.Click += new System.EventHandler(this.btnEditDefect_Click);
            // 
            // btnEditBrigade
            // 
            this.btnEditBrigade.Location = new System.Drawing.Point(342, 66);
            this.btnEditBrigade.Name = "btnEditBrigade";
            this.btnEditBrigade.Size = new System.Drawing.Size(34, 23);
            this.btnEditBrigade.TabIndex = 13;
            this.btnEditBrigade.Text = "✎";
            this.btnEditBrigade.UseVisualStyleBackColor = true;
            this.btnEditBrigade.Click += new System.EventHandler(this.btnEditBrigade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Машина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дефект";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Бригада";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Начало ремонта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Стоимость работы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Статус";
            // 
            // RepairEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 223);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditBrigade);
            this.Controls.Add(this.btnEditDefect);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.nudLabor);
            this.Controls.Add(this.dtReceived);
            this.Controls.Add(this.btnAddBrigade);
            this.Controls.Add(this.cbBrigade);
            this.Controls.Add(this.btnAddDefect);
            this.Controls.Add(this.cbDefect);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.cbCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepairEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый ремонт";
            ((System.ComponentModel.ISupportInitialize)(this.nudLabor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnEditDefect;
        private System.Windows.Forms.Button btnEditBrigade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}