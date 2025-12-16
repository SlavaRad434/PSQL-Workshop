using System.Windows.Forms;

namespace Workshop2.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRepairs;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFinish;


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
            this.dgvRepairs = new System.Windows.Forms.DataGridView();
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.представленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производительностьБригадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стоимостьРемонтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подробныеРемонтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомабилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дефектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мастерскиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRepairs
            // 
            this.dgvRepairs.AllowUserToResizeRows = false;
            this.dgvRepairs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepairs.Location = new System.Drawing.Point(12, 49);
            this.dgvRepairs.Name = "dgvRepairs";
            this.dgvRepairs.ReadOnly = true;
            this.dgvRepairs.RowHeadersVisible = false;
            this.dgvRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepairs.Size = new System.Drawing.Size(760, 350);
            this.dgvRepairs.TabIndex = 0;
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRepair.Location = new System.Drawing.Point(12, 405);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(120, 33);
            this.btnAddRepair.TabIndex = 1;
            this.btnAddRepair.Text = "Новый ремонт";
            this.btnAddRepair.UseVisualStyleBackColor = true;
            this.btnAddRepair.Click += new System.EventHandler(this.btnAddRepair_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(652, 405);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 33);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(138, 405);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 33);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(264, 405);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(120, 35);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "Завершить";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.представленияToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.бригадыToolStripMenuItem,
            this.автомабилиToolStripMenuItem,
            this.дефектыToolStripMenuItem,
            this.деталиToolStripMenuItem,
            this.мастерскиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // представленияToolStripMenuItem
            // 
            this.представленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производительностьБригадToolStripMenuItem,
            this.автомобилиToolStripMenuItem,
            this.стоимостьРемонтаToolStripMenuItem,
            this.подробныеРемонтыToolStripMenuItem});
            this.представленияToolStripMenuItem.Name = "представленияToolStripMenuItem";
            this.представленияToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.представленияToolStripMenuItem.Text = "Представления";
            // 
            // производительностьБригадToolStripMenuItem
            // 
            this.производительностьБригадToolStripMenuItem.CheckOnClick = true;
            this.производительностьБригадToolStripMenuItem.Name = "производительностьБригадToolStripMenuItem";
            this.производительностьБригадToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.производительностьБригадToolStripMenuItem.Text = "Производительность бригад";
            this.производительностьБригадToolStripMenuItem.Click += new System.EventHandler(this.btnBrigade);
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.CheckOnClick = true;
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.btnCar);
            // 
            // стоимостьРемонтаToolStripMenuItem
            // 
            this.стоимостьРемонтаToolStripMenuItem.CheckOnClick = true;
            this.стоимостьРемонтаToolStripMenuItem.Name = "стоимостьРемонтаToolStripMenuItem";
            this.стоимостьРемонтаToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.стоимостьРемонтаToolStripMenuItem.Text = "Стоимость ремонта";
            this.стоимостьРемонтаToolStripMenuItem.Click += new System.EventHandler(this.btnCost);
            // 
            // подробныеРемонтыToolStripMenuItem
            // 
            this.подробныеРемонтыToolStripMenuItem.CheckOnClick = true;
            this.подробныеРемонтыToolStripMenuItem.Name = "подробныеРемонтыToolStripMenuItem";
            this.подробныеРемонтыToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.подробныеРемонтыToolStripMenuItem.Text = "Подробные ремонты";
            this.подробныеРемонтыToolStripMenuItem.Click += new System.EventHandler(this.btnDetailed);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.CheckOnClick = true;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.btnAddPersonal_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // бригадыToolStripMenuItem
            // 
            this.бригадыToolStripMenuItem.Name = "бригадыToolStripMenuItem";
            this.бригадыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.бригадыToolStripMenuItem.Text = "Бригады";
            // 
            // автомабилиToolStripMenuItem
            // 
            this.автомабилиToolStripMenuItem.Name = "автомабилиToolStripMenuItem";
            this.автомабилиToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.автомабилиToolStripMenuItem.Text = "Автомобили";
            // 
            // дефектыToolStripMenuItem
            // 
            this.дефектыToolStripMenuItem.Name = "дефектыToolStripMenuItem";
            this.дефектыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.дефектыToolStripMenuItem.Text = "Дефекты";
            // 
            // деталиToolStripMenuItem
            // 
            this.деталиToolStripMenuItem.Name = "деталиToolStripMenuItem";
            this.деталиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.деталиToolStripMenuItem.Text = "Детали";
            // 
            // мастерскиеToolStripMenuItem
            // 
            this.мастерскиеToolStripMenuItem.Name = "мастерскиеToolStripMenuItem";
            this.мастерскиеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.мастерскиеToolStripMenuItem.Text = "Мастерские";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddRepair);
            this.Controls.Add(this.dgvRepairs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Мастерская ремонта автомобилей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem представленияToolStripMenuItem;
        private ToolStripMenuItem производительностьБригадToolStripMenuItem;
        private ToolStripMenuItem автомобилиToolStripMenuItem;
        private ToolStripMenuItem стоимостьРемонтаToolStripMenuItem;
        private ToolStripMenuItem подробныеРемонтыToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private Button btnDelete;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem бригадыToolStripMenuItem;
        private ToolStripMenuItem автомабилиToolStripMenuItem;
        private ToolStripMenuItem дефектыToolStripMenuItem;
        private ToolStripMenuItem деталиToolStripMenuItem;
        private ToolStripMenuItem мастерскиеToolStripMenuItem;
    }
}