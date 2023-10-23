
namespace AASOTE
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CamScanPB = new System.Windows.Forms.PictureBox();
            this.ScanButt = new System.Windows.Forms.Button();
            this.SelectDevicesLB = new System.Windows.Forms.ListBox();
            this.SelectDeviceButt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamScanPB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CamScanPB
            // 
            this.CamScanPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.CamScanPB.Location = new System.Drawing.Point(0, 0);
            this.CamScanPB.Name = "CamScanPB";
            this.CamScanPB.Size = new System.Drawing.Size(924, 514);
            this.CamScanPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CamScanPB.TabIndex = 0;
            this.CamScanPB.TabStop = false;
            this.CamScanPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CamScanPB_MouseDown);
            // 
            // ScanButt
            // 
            this.ScanButt.BackColor = System.Drawing.Color.Gray;
            this.ScanButt.FlatAppearance.BorderSize = 0;
            this.ScanButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanButt.Location = new System.Drawing.Point(1046, 457);
            this.ScanButt.Name = "ScanButt";
            this.ScanButt.Size = new System.Drawing.Size(125, 45);
            this.ScanButt.TabIndex = 1;
            this.ScanButt.Text = "Сканировать";
            this.ScanButt.UseVisualStyleBackColor = false;
            this.ScanButt.Click += new System.EventHandler(this.ScanButt_Click);
            // 
            // SelectDevicesLB
            // 
            this.SelectDevicesLB.FormattingEnabled = true;
            this.SelectDevicesLB.ItemHeight = 16;
            this.SelectDevicesLB.Location = new System.Drawing.Point(930, 273);
            this.SelectDevicesLB.Name = "SelectDevicesLB";
            this.SelectDevicesLB.Size = new System.Drawing.Size(241, 116);
            this.SelectDevicesLB.TabIndex = 2;
            this.SelectDevicesLB.Visible = false;
            // 
            // SelectDeviceButt
            // 
            this.SelectDeviceButt.BackColor = System.Drawing.Color.Gray;
            this.SelectDeviceButt.FlatAppearance.BorderSize = 0;
            this.SelectDeviceButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectDeviceButt.Location = new System.Drawing.Point(930, 273);
            this.SelectDeviceButt.Name = "SelectDeviceButt";
            this.SelectDeviceButt.Size = new System.Drawing.Size(241, 116);
            this.SelectDeviceButt.TabIndex = 3;
            this.SelectDeviceButt.Text = "Выбор камеры";
            this.SelectDeviceButt.UseVisualStyleBackColor = false;
            this.SelectDeviceButt.Click += new System.EventHandler(this.SelectDeviceButt_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1046, 426);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(930, 395);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(110, 107);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(1046, 395);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 25);
            this.textBox4.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПользователяToolStripMenuItem,
            this.авторизоватьсяToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(930, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(143, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            this.добавитьПользователяToolStripMenuItem.Visible = false;
            this.добавитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
            // 
            // авторизоватьсяToolStripMenuItem
            // 
            this.авторизоватьсяToolStripMenuItem.Name = "авторизоватьсяToolStripMenuItem";
            this.авторизоватьсяToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.авторизоватьсяToolStripMenuItem.Text = "Авторизоваться";
            this.авторизоватьсяToolStripMenuItem.Click += new System.EventHandler(this.авторизоватьсяToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1151, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(1125, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1176, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SelectDeviceButt);
            this.Controls.Add(this.SelectDevicesLB);
            this.Controls.Add(this.ScanButt);
            this.Controls.Add(this.CamScanPB);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CamScanPB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox CamScanPB;
        public System.Windows.Forms.Button ScanButt;
        public System.Windows.Forms.ListBox SelectDevicesLB;
        public System.Windows.Forms.Button SelectDeviceButt;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem авторизоватьсяToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

