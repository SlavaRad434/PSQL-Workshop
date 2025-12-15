using System.Windows.Forms;

namespace Workshop2.Forms
{
    partial class CarEditForm
    {
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;


        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.lblVin = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();


            // FORM
            this.Text = "Редактировать автомобиль";
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            // TABLE LAYOUT
            this.layout.ColumnCount = 2;
            this.layout.RowCount = 6;
            this.layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout.Padding = new System.Windows.Forms.Padding(10);
            this.layout.AutoSize = true;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100));




            // LABELS
            this.lblVin.Text = "VIN:";
            this.lblBody.Text = "Кузов №:";
            this.lblEngine.Text = "Двигатель №:";
            this.lblOwner.Text = "Владелец:";
            this.lblPhone.Text = "Телефон:";


            TextBox[] inputs = { txtVin, txtBody, txtEngine, txtOwner, txtPhone };
            Label[] labels = { lblVin, lblBody, lblEngine, lblOwner, lblPhone };


            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Dock = System.Windows.Forms.DockStyle.Fill;
                labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                inputs[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.layout.Controls.Add(labels[i], 0, i);
                this.layout.Controls.Add(inputs[i], 1, i);
            }


            // BUTTON SAVE
            this.btnSave.Text = "Сохранить";
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Height = 40;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            //this.button1.Location = new System.Drawing.Point(300, 300);
            this.button1.Name = "button1";
            //this.button1.Size = new System.Drawing.Size(71, 21);
            //this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Height = 40;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);


            // ADD CONTROLS
            this.Controls.Add(this.layout);
            this.Controls.Add(this.btnSave);


            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private Button button1;
    }
}
