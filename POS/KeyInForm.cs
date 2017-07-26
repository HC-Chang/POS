using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class KeyInForm : Form
    {
        // 初始化
        public KeyInForm()
        {
            InitializeComponent();
        }

        // 初始化
        public KeyInForm(string KeyValue)
        {
            InitializeComponent();
            this.label1.Text = KeyValue;
        }



        // 快捷鍵
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // Enter 鍵 -> 確認按鈕
            if (keyData == Keys.Enter && !this.confirm_button.Focused)
            {
                confirm_button_Click(null, null);
            }
            return base.ProcessDialogKey(keyData);
        }

        public bool IfCancel = false;

        #region button

        // 確認
        private void confirm_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 取消
        private void cancel_button_Click(object sender, EventArgs e)
        {
            IfCancel = true;
            this.Close();
        }

        #endregion

    }
}
