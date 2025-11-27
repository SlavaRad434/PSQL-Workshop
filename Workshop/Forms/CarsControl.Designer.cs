namespace Workshop.Forms
{
    partial class CarsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AutoGenerateColumns = false;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.vinDataGridViewTextBoxColumn,
            this.bodyNumberDataGridViewTextBoxColumn,
            this.engineNumberDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.ownerPhoneDataGridViewTextBoxColumn,
            this.repairsDataGridViewTextBoxColumn,
            this.partsDataGridViewTextBoxColumn});
            this.dataGridViewCars.DataSource = this.carBindingSource;
            this.dataGridViewCars.Location = new System.Drawing.Point(17, 15);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(400, 168);
            this.dataGridViewCars.TabIndex = 0;
            this.dataGridViewCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellContentClick);
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            // 
            // vinDataGridViewTextBoxColumn
            // 
            this.vinDataGridViewTextBoxColumn.DataPropertyName = "Vin";
            this.vinDataGridViewTextBoxColumn.HeaderText = "Vin";
            this.vinDataGridViewTextBoxColumn.Name = "vinDataGridViewTextBoxColumn";
            // 
            // bodyNumberDataGridViewTextBoxColumn
            // 
            this.bodyNumberDataGridViewTextBoxColumn.DataPropertyName = "BodyNumber";
            this.bodyNumberDataGridViewTextBoxColumn.HeaderText = "BodyNumber";
            this.bodyNumberDataGridViewTextBoxColumn.Name = "bodyNumberDataGridViewTextBoxColumn";
            // 
            // engineNumberDataGridViewTextBoxColumn
            // 
            this.engineNumberDataGridViewTextBoxColumn.DataPropertyName = "EngineNumber";
            this.engineNumberDataGridViewTextBoxColumn.HeaderText = "EngineNumber";
            this.engineNumberDataGridViewTextBoxColumn.Name = "engineNumberDataGridViewTextBoxColumn";
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            // 
            // ownerPhoneDataGridViewTextBoxColumn
            // 
            this.ownerPhoneDataGridViewTextBoxColumn.DataPropertyName = "OwnerPhone";
            this.ownerPhoneDataGridViewTextBoxColumn.HeaderText = "OwnerPhone";
            this.ownerPhoneDataGridViewTextBoxColumn.Name = "ownerPhoneDataGridViewTextBoxColumn";
            // 
            // repairsDataGridViewTextBoxColumn
            // 
            this.repairsDataGridViewTextBoxColumn.DataPropertyName = "Repairs";
            this.repairsDataGridViewTextBoxColumn.HeaderText = "Repairs";
            this.repairsDataGridViewTextBoxColumn.Name = "repairsDataGridViewTextBoxColumn";
            // 
            // partsDataGridViewTextBoxColumn
            // 
            this.partsDataGridViewTextBoxColumn.DataPropertyName = "Parts";
            this.partsDataGridViewTextBoxColumn.HeaderText = "Parts";
            this.partsDataGridViewTextBoxColumn.Name = "partsDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(Workshop.Models.Car);
            // 
            // CarsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewCars);
            this.Name = "CarsControl";
            this.Size = new System.Drawing.Size(568, 311);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
    }
}
