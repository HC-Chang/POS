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
    public partial class BMS_Form : Form
    {
        public BMS_Form()
        {
            InitializeComponent();
        }

        // Order Form
        public Order_Form of3;
        pos_model model;

        // KeyIn Form
        KeyInForm kif;
        string[] adds = new string[] { "種類", "品項", "價錢" };
        string[] keep_datas = new string [3];

        // List Form
        list_Form lf;

        #region Menu

        // 新增菜單資料
        private void new_menu_button_Click(object sender, EventArgs e)
        {
            // 清除暫存資料
            clean_data();

            // 新增菜單資料
            add_data();

            // 資料進入資料庫
            model.Add_Menu(keep_datas[0], keep_datas[1], keep_datas[2]);
            
            //text_Form t_f = new text_Form(item + "-"+price);
            //t_f.Show();
        }

        // 刪除
        private void delete_menu_button_Click(object sender, EventArgs e)
        {
            Object[] o = new Object[] {model.items_count, model.Show_Menu_Types(), model.Show_Menu_Names(), model.Show_Menu_Price() };
            lf = new list_Form(o);
            lf.ShowDialog();
        }

        // 修改

        // 檢視

        #endregion



        #region Confirm / Cancel Button

        // 確定 button
        private void confirm_button_Click(object sender, EventArgs e)
        {
            // ***
            // 資料載入 (list 為參考型別 -> 不用替換)
            //of3._Model = model;
            // ***

            // 資料顯示
            of3.display_data();
            
            // 關閉視窗
            this.Close();
        }

        // 取消 button
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#endregion

        // 快捷鍵
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // Enter 鍵 -> 確認按鈕
            if (keyData == Keys.Enter && !this.confirm_button.Focused)
            {
                confirm_button_Click(null, null);
            }

            // N 鍵 -> 新增
            if (keyData == Keys.N && !this.new_menu_button.Focused)
            {
                new_menu_button_Click(null, null);
            }

            // D 鍵 -> 刪除
            if (keyData == Keys.D && !this.new_menu_button.Focused)
            {
                delete_menu_button_Click(null, null);
            }



            return base.ProcessDialogKey(keyData);
        }



        #region KeyInForm

        // 清除資料
        private void clean_data()
        {
            for (int i = 0; i < keep_datas.Length; i++)
            {
                keep_datas[i] = "";
            }
        }

        // 加入資料
        private void add_data()
        {
            for (int i = 0; i < adds.Length; i++)
            {
                kif = new KeyInForm(adds[i]);
                kif.ShowDialog();
                keep_datas[i] = kif.key_in_textBox.Text;
            }
        }

#endregion



        // Form 載入
        private void BMS_Form_Load(object sender, EventArgs e)
        {
            // 初始化 model
            model = of3._Model;
        }


    }
}
