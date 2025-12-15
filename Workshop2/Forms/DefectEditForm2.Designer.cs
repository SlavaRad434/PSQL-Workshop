namespace Workshop2.Forms
{
    partial class DefectEditForm
    {
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numLabor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.DataGridView gridParts;

        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.numLabor = new System.Windows.Forms.NumericUpDown();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.gridParts = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLabor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParts)).BeginInit();
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
            this.layout.Controls.Add(this.lblLabor, 0, 1);
            this.layout.Controls.Add(this.numLabor, 1, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Padding = new System.Windows.Forms.Padding(10);
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.layout.Size = new System.Drawing.Size(600, 80);
            this.layout.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(13, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название:";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(163, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(424, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblLabor
            // 
            this.lblLabor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabor.Location = new System.Drawing.Point(13, 36);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(144, 26);
            this.lblLabor.TabIndex = 2;
            this.lblLabor.Text = "Базовая работа:";
            // 
            // numLabor
            // 
            this.numLabor.DecimalPlaces = 2;
            this.numLabor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLabor.Location = new System.Drawing.Point(163, 39);
            this.numLabor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLabor.Name = "numLabor";
            this.numLabor.Size = new System.Drawing.Size(424, 20);
            this.numLabor.TabIndex = 3;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPart.Location = new System.Drawing.Point(0, 80);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(600, 35);
            this.btnAddPart.TabIndex = 1;
            this.btnAddPart.Text = "➕ Добавить деталь";
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // gridParts
            // 
            this.gridParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridParts.Location = new System.Drawing.Point(0, 115);
            this.gridParts.Name = "gridParts";
            this.gridParts.ReadOnly = true;
            this.gridParts.Size = new System.Drawing.Size(600, 245);
            this.gridParts.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(600, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(600, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DefectEditForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridParts);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.btnSave);
            this.Name = "DefectEditForm";
            this.Text = "Неисправность";
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLabor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
    }
}