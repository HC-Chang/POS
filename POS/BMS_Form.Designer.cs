namespace POS
{
    partial class BMS_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.inspect_menu_button = new System.Windows.Forms.Button();
            this.modify_menu_button = new System.Windows.Forms.Button();
            this.delete_menu_button = new System.Windows.Forms.Button();
            this.new_menu_button = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_menu
            // 
            this.gb_menu.Controls.Add(this.inspect_menu_button);
            this.gb_menu.Controls.Add(this.modify_menu_button);
            this.gb_menu.Controls.Add(this.delete_menu_button);
            this.gb_menu.Controls.Add(this.new_menu_button);
            this.gb_menu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb_menu.ForeColor = System.Drawing.Color.White;
            this.gb_menu.Location = new System.Drawing.Point(13, 13);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Size = new System.Drawing.Size(259, 252);
            this.gb_menu.TabIndex = 0;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "菜單";
            // 
            // inspect_menu_button
            // 
            this.inspect_menu_button.ForeColor = System.Drawing.Color.Black;
            this.inspect_menu_button.Location = new System.Drawing.Point(7, 188);
            this.inspect_menu_button.Name = "inspect_menu_button";
            this.inspect_menu_button.Size = new System.Drawing.Size(245, 40);
            this.inspect_menu_button.TabIndex = 3;
            this.inspect_menu_button.TabStop = false;
            this.inspect_menu_button.Text = "檢視 (I)";
            this.inspect_menu_button.UseVisualStyleBackColor = true;
            this.inspect_menu_button.Click += new System.EventHandler(this.inspect_menu_button_Click);
            // 
            // modify_menu_button
            // 
            this.modify_menu_button.ForeColor = System.Drawing.Color.Black;
            this.modify_menu_button.Location = new System.Drawing.Point(7, 136);
            this.modify_menu_button.Name = "modify_menu_button";
            this.modify_menu_button.Size = new System.Drawing.Size(245, 40);
            this.modify_menu_button.TabIndex = 2;
            this.modify_menu_button.TabStop = false;
            this.modify_menu_button.Text = "修改 (M)";
            this.modify_menu_button.UseVisualStyleBackColor = true;
            this.modify_menu_button.Click += new System.EventHandler(this.modify_menu_button_Click);
            // 
            // delete_menu_button
            // 
            this.delete_menu_button.ForeColor = System.Drawing.Color.Black;
            this.delete_menu_button.Location = new System.Drawing.Point(7, 84);
            this.delete_menu_button.Name = "delete_menu_button";
            this.delete_menu_button.Size = new System.Drawing.Size(245, 40);
            this.delete_menu_button.TabIndex = 1;
            this.delete_menu_button.TabStop = false;
            this.delete_menu_button.Text = "刪除 (D)";
            this.delete_menu_button.UseVisualStyleBackColor = true;
            this.delete_menu_button.Click += new System.EventHandler(this.delete_menu_button_Click);
            // 
            // new_menu_button
            // 
            this.new_menu_button.ForeColor = System.Drawing.Color.Black;
            this.new_menu_button.Location = new System.Drawing.Point(7, 32);
            this.new_menu_button.Name = "new_menu_button";
            this.new_menu_button.Size = new System.Drawing.Size(245, 40);
            this.new_menu_button.TabIndex = 0;
            this.new_menu_button.TabStop = false;
            this.new_menu_button.Text = "新增 (N)";
            this.new_menu_button.UseVisualStyleBackColor = true;
            this.new_menu_button.Click += new System.EventHandler(this.new_menu_button_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.confirm_button.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirm_button.Location = new System.Drawing.Point(0, 0);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(256, 100);
            this.confirm_button.TabIndex = 1;
            this.confirm_button.Text = "確定";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel_button.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancel_button.Location = new System.Drawing.Point(256, 0);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(256, 100);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirm_button);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 100);
            this.panel1.TabIndex = 3;
            // 
            // BMS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(123)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(512, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BMS_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "後臺管理系統";
            this.Load += new System.EventHandler(this.BMS_Form_Load);
            this.gb_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.Button new_menu_button;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button delete_menu_button;
        private System.Windows.Forms.Button modify_menu_button;
        private System.Windows.Forms.Button inspect_menu_button;
        private System.Windows.Forms.Panel panel1;
    }
}