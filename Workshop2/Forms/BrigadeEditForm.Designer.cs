namespace Workshop2.Forms
{
    partial class BrigadeEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private Workshop2.Controls.SearchComboBox cbWorkshop;
        private System.Windows.Forms.Label lblWorkshop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPersonal;
        private System.Windows.Forms.DataGridView gridPersonnel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWorkshop = new System.Windows.Forms.Label();
            this.cbWorkshop = new Workshop2.Controls.SearchComboBox();
            this.btnAddPersonal = new System.Windows.Forms.Button();
            this.gridPersonnel = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.AutoSize = true;
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.lblName, 0, 0);
            this.layout.Controls.Add(this.txtName, 1, 0);
            this.layout.Controls.Add(this.lblWorkshop, 0, 1);
            this.layout.Controls.Add(this.cbWorkshop, 1, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Padding = new System.Windows.Forms.Padding(10);
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layout.Size = new System.Drawing.Size(600, 72);
            this.layout.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(13, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название бригады:";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(163, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(424, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblWorkshop
            // 
            this.lblWorkshop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkshop.Location = new System.Drawing.Point(13, 36);
            this.lblWorkshop.Name = "lblWorkshop";
            this.lblWorkshop.Size = new System.Drawing.Size(144, 26);
            this.lblWorkshop.TabIndex = 2;
            this.lblWorkshop.Text = "Мастерская:";
            // 
            // cbWorkshop
            // 
            this.cbWorkshop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWorkshop.FormattingEnabled = true;
            this.cbWorkshop.Location = new System.Drawing.Point(163, 39);
            this.cbWorkshop.Name = "cbWorkshop";
            this.cbWorkshop.Size = new System.Drawing.Size(424, 21);
            this.cbWorkshop.TabIndex = 3;
            // 
            // btnAddPersonal
            // 
            this.btnAddPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPersonal.Location = new System.Drawing.Point(0, 72);
            this.btnAddPersonal.Name = "btnAddPersonal";
            this.btnAddPersonal.Size = new System.Drawing.Size(600, 35);
            this.btnAddPersonal.TabIndex = 4;
            this.btnAddPersonal.Text = "➕ Добавить сотрудника";
            this.btnAddPersonal.UseVisualStyleBackColor = true;
            this.btnAddPersonal.Click += new System.EventHandler(this.btnAddPersonnel_Click);
            // 
            // gridPersonnel
            // 
            this.gridPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPersonnel.Location = new System.Drawing.Point(0, 107);
            this.gridPersonnel.Name = "gridPersonnel";
            this.gridPersonnel.ReadOnly = true;
            this.gridPersonnel.Size = new System.Drawing.Size(600, 253);
            this.gridPersonnel.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(600, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(0, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(600, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BrigadeEditForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.gridPersonnel);
            this.Controls.Add(this.btnAddPersonal);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "BrigadeEditForm";
            this.Text = "Бригада";
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
