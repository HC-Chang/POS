namespace POS
{
    partial class Order_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.order_ts_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_ts_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bms_ts_button = new System.Windows.Forms.ToolStripButton();
            this.Order_Checked_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_listBox = new System.Windows.Forms.ListBox();
            this.count_listBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.toolStrip1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order_ts_button,
            this.toolStripSeparator2,
            this.ts_ts_button,
            this.toolStripSeparator1,
            this.bms_ts_button,
            this.Order_Checked_Button,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1024, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // order_ts_button
            // 
            this.order_ts_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.order_ts_button.ForeColor = System.Drawing.Color.White;
            this.order_ts_button.Image = ((System.Drawing.Image)(resources.GetObject("order_ts_button.Image")));
            this.order_ts_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.order_ts_button.Name = "order_ts_button";
            this.order_ts_button.Size = new System.Drawing.Size(52, 28);
            this.order_ts_button.Text = "點菜";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // ts_ts_button
            // 
            this.ts_ts_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_ts_button.ForeColor = System.Drawing.Color.White;
            this.ts_ts_button.Image = ((System.Drawing.Image)(resources.GetObject("ts_ts_button.Image")));
            this.ts_ts_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_ts_button.Name = "ts_ts_button";
            this.ts_ts_button.Size = new System.Drawing.Size(90, 28);
            this.ts_ts_button.Text = "報表系統";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bms_ts_button
            // 
            this.bms_ts_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bms_ts_button.ForeColor = System.Drawing.Color.White;
            this.bms_ts_button.Image = ((System.Drawing.Image)(resources.GetObject("bms_ts_button.Image")));
            this.bms_ts_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bms_ts_button.Name = "bms_ts_button";
            this.bms_ts_button.Size = new System.Drawing.Size(159, 28);
            this.bms_ts_button.Text = "後臺管理系統 (B)";
            this.bms_ts_button.Click += new System.EventHandler(this.bms_ts_button_Click);
            // 
            // Order_Checked_Button
            // 
            this.Order_Checked_Button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Order_Checked_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Order_Checked_Button.ForeColor = System.Drawing.Color.White;
            this.Order_Checked_Button.Image = ((System.Drawing.Image)(resources.GetObject("Order_Checked_Button.Image")));
            this.Order_Checked_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Order_Checked_Button.Name = "Order_Checked_Button";
            this.Order_Checked_Button.Size = new System.Drawing.Size(90, 28);
            this.Order_Checked_Button.Text = "確認點餐";
            this.Order_Checked_Button.Click += new System.EventHandler(this.Order_Checked_Button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // menu_listBox
            // 
            this.menu_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_listBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menu_listBox.FormattingEnabled = true;
            this.menu_listBox.ItemHeight = 27;
            this.menu_listBox.Location = new System.Drawing.Point(0, 0);
            this.menu_listBox.Name = "menu_listBox";
            this.menu_listBox.Size = new System.Drawing.Size(171, 737);
            this.menu_listBox.TabIndex = 2;
            this.menu_listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_listBox_MouseDown);
            // 
            // count_listBox
            // 
            this.count_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.count_listBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.count_listBox.FormattingEnabled = true;
            this.count_listBox.ItemHeight = 27;
            this.count_listBox.Location = new System.Drawing.Point(0, 0);
            this.count_listBox.Name = "count_listBox";
            this.count_listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.count_listBox.Size = new System.Drawing.Size(110, 737);
            this.count_listBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menu_listBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 737);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.count_listBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(171, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 737);
            this.panel2.TabIndex = 5;
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_Form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_Form_FormClosing);
            this.Load += new System.EventHandler(this.Order_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton order_ts_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_ts_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bms_ts_button;
        private System.Windows.Forms.ToolStripButton Order_Checked_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ListBox count_listBox;
        public System.Windows.Forms.ListBox menu_listBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

