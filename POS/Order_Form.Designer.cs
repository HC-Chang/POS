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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order_ts_button,
            this.toolStripSeparator2,
            this.ts_ts_button,
            this.toolStripSeparator1,
            this.bms_ts_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Order_Form";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        public System.Windows.Forms.Label label1;
    }
}

