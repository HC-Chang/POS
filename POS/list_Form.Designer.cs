namespace POS
{
    partial class list_Form
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(484, 389);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // confirm_button
            // 
            this.confirm_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.confirm_button.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirm_button.Location = new System.Drawing.Point(0, 389);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(160, 80);
            this.confirm_button.TabIndex = 1;
            this.confirm_button.Text = "確認";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel_button.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancel_button.Location = new System.Drawing.Point(324, 389);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(160, 80);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset_button.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reset_button.Location = new System.Drawing.Point(160, 389);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(164, 80);
            this.reset_button.TabIndex = 3;
            this.reset_button.Text = "重新設定";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // list_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 469);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "list_Form";
            this.Text = "list_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button reset_button;
    }
}