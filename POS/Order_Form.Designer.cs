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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menu_listBox = new System.Windows.Forms.ListBox();
            this.count_listBox = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order_ts_button,
            this.toolStripSeparator2,
            this.ts_ts_button,
            this.toolStripSeparator1,
            this.bms_ts_button,
            this.toolStripButton1,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(535, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // order_ts_button
            // 
            this.order_ts_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.order_ts_button.Image = ((System.Drawing.Image)(resources.GetObject("order_ts_button.Image")));
            this.order_ts_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.order_ts_button.Name = "order_ts_button";
            this.order_ts_button.Size = new System.Drawing.Size(36, 22);
            this.order_ts_button.Text = "點菜";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_ts_button
            // 
            this.ts_ts_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_ts_button.Image = ((System.Drawing.Image)(resources.GetObject("ts_ts_button.Image")));
            this.ts_ts_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_ts_button.Name = "ts_ts_button";
            this.ts_ts_button.Size = new System.Drawing.Size(60, 22);
            this.ts_ts_button.Text = "報表系統";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bms_ts_button
            // 
            this.bms_ts_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bms_ts_button.Image = ((System.Drawing.Image)(resources.GetObject("bms_ts_button.Image")));
            this.bms_ts_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bms_ts_button.Name = "bms_ts_button";
            this.bms_ts_button.Size = new System.Drawing.Size(84, 22);
            this.bms_ts_button.Text = "後臺管理系統";
            this.bms_ts_button.Click += new System.EventHandler(this.bms_ts_button_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "確認點餐";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menu_listBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.count_listBox);
            this.splitContainer1.Size = new System.Drawing.Size(535, 303);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 3;
            // 
            // menu_listBox
            // 
            this.menu_listBox.FormattingEnabled = true;
            this.menu_listBox.ItemHeight = 12;
            this.menu_listBox.Location = new System.Drawing.Point(3, 3);
            this.menu_listBox.Name = "menu_listBox";
            this.menu_listBox.Size = new System.Drawing.Size(182, 292);
            this.menu_listBox.TabIndex = 2;
            this.menu_listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_listBox_MouseDown);
            // 
            // count_listBox
            // 
            this.count_listBox.FormattingEnabled = true;
            this.count_listBox.ItemHeight = 12;
            this.count_listBox.Location = new System.Drawing.Point(4, 4);
            this.count_listBox.Name = "count_listBox";
            this.count_listBox.Size = new System.Drawing.Size(328, 292);
            this.count_listBox.TabIndex = 0;
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 328);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Order_Form";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ListBox count_listBox;
        public System.Windows.Forms.ListBox menu_listBox;
    }
}

