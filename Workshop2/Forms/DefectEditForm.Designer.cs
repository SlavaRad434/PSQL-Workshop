//using System.Windows.Forms;

//    namespace Workshop2.Forms
//{
//    partial class DefectEditForm
//    {
//        private System.ComponentModel.IContainer components = null;
//        private Label lblName;
//        private TextBox tbName;
//        private Label lblBaseLaborCost;
//        private NumericUpDown nudBaseLaborCost;
//        private Button btnSave;
//        private DataGridView dgvParts;
//        private Button btnAddPart;
//        private Label lblParts;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.lblName = new Label();
//            this.tbName = new TextBox();
//            this.lblBaseLaborCost = new Label();
//            this.nudBaseLaborCost = new NumericUpDown();
//            this.btnSave = new Button();
//            this.dgvParts = new DataGridView();
//            this.btnAddPart = new Button();
//            this.lblParts = new Label();

//            ((System.ComponentModel.ISupportInitialize)(this.nudBaseLaborCost)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();

//            this.SuspendLayout();

//            // 
//            // lblName
//            // 
//            this.lblName.Text = "Название:";
//            this.lblName.Location = new System.Drawing.Point(20, 20);
//            this.lblName.Size = new System.Drawing.Size(120, 30);

//            // 
//            // tbName
//            // 
//            this.tbName.Location = new System.Drawing.Point(150, 20);
//            this.tbName.Size = new System.Drawing.Size(260, 27);

//            // 
//            // lblBaseLaborCost
//            // 
//            this.lblBaseLaborCost.Text = "Работы (база):";
//            this.lblBaseLaborCost.Location = new System.Drawing.Point(20, 65);
//            this.lblBaseLaborCost.Size = new System.Drawing.Size(120, 30);

//            // 
//            // nudBaseLaborCost
//            // 
//            this.nudBaseLaborCost.Location = new System.Drawing.Point(150, 65);
//            this.nudBaseLaborCost.DecimalPlaces = 2;
//            this.nudBaseLaborCost.Maximum = 1000000;
//            this.nudBaseLaborCost.Size = new System.Drawing.Size(260, 27);

//            // 
//            // lblParts
//            // 
//            this.lblParts.Text = "Детали:";
//            this.lblParts.Location = new System.Drawing.Point(20, 115);
//            this.lblParts.Size = new System.Drawing.Size(100, 30);

//            // 
//            // btnAddPart
//            // 
//            this.btnAddPart.Text = "➕";
//            this.btnAddPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
//            this.btnAddPart.Location = new System.Drawing.Point(390, 110);
//            this.btnAddPart.Size = new System.Drawing.Size(40, 35);
//            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);

//            // 
//            // dgvParts
//            // 
//            this.dgvParts.Location = new System.Drawing.Point(20, 155);
//            this.dgvParts.Size = new System.Drawing.Size(410, 220);
//            this.dgvParts.ReadOnly = true;
//            this.dgvParts.AllowUserToAddRows = false;
//            this.dgvParts.AllowUserToDeleteRows = false;
//            this.dgvParts.RowHeadersVisible = false;
//            this.dgvParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgvParts.AllowUserToResizeRows = false; // запрет на изменение высоты строки
//            this.dgvParts.MultiSelect = false;
//            this.dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

//            // 
//            // btnSave
//            // 
//            this.btnSave.Text = "Сохранить";
//            this.btnSave.Location = new System.Drawing.Point(20, 390);
//            this.btnSave.Size = new System.Drawing.Size(410, 35);
//            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

//            // 
//            // DefectEditForm
//            // 
//            this.ClientSize = new System.Drawing.Size(450, 450);
//            this.Controls.Add(this.lblName);
//            this.Controls.Add(this.tbName);
//            this.Controls.Add(this.lblBaseLaborCost);
//            this.Controls.Add(this.nudBaseLaborCost);
//            this.Controls.Add(this.lblParts);
//            this.Controls.Add(this.btnAddPart);
//            this.Controls.Add(this.dgvParts);
//            this.Controls.Add(this.btnSave);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.StartPosition = FormStartPosition.CenterParent;
//            this.Text = "Неисправность";

//            ((System.ComponentModel.ISupportInitialize)(this.nudBaseLaborCost)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();

//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }
//    }
//}