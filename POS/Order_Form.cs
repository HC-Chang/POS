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
    public partial class Order_Form : Form
    {
        public pos_model _Model = new pos_model();
        BMS_Form bms_form = new BMS_Form();

        public string[] menu_datas;


        public Order_Form()
        {
            InitializeComponent();
            bms_form.of = this;
        }




//        public List<Menu> l_menu = new List<Menu>();
        
/*****************/
/*
        public class Menu
        {
            public string name { get; set; }
            public int price { get; set; }
        }
*/


        private void Order_Form_Load(object sender, EventArgs e)
        {
            // 匯入資料
            _Model.Import_Menu();

            // 資料載入
            menu_datas = _Model.Show_Menu_Names();

            // 顯示資料
            display_data();
        }

        #region  功能列表 - tool strip button

        // 開啟後臺管理 Form
        private void bms_ts_button_Click(object sender, EventArgs e)
        {
            bms_form.ShowDialog();
        }

        // 確認點餐
        private void Order_Checked_Button_Click(object sender, EventArgs e)
        {

        }


        #endregion



        // bug - 須 Focus 項目上
        /********************/
        // 項目 增加/減少
        private void menu_listBox_MouseDown(object sender, MouseEventArgs e)
        {
            // 無品項時跳出
            if (menu_listBox.SelectedIndex == -1)
            {
                return;
            }

            // 品項增加
            // bug - 須 Focus 項目上
            if (e.Button == MouseButtons.Left)
            {
                count_listBox.Items[menu_listBox.SelectedIndex] = (Convert.ToInt16(count_listBox.Items[menu_listBox.SelectedIndex].ToString()) + 1).ToString();
            }

            // 品項減少
            if (e.Button == MouseButtons.Right && Convert.ToInt16(count_listBox.Items[menu_listBox.SelectedIndex].ToString()) > 0)
            {
                count_listBox.Items[menu_listBox.SelectedIndex] = (Convert.ToInt16(count_listBox.Items[menu_listBox.SelectedIndex].ToString()) - 1).ToString();
            }
        }



        // 顯示資料
        public void display_data()
        {
            menu_listBox.Items.Clear();
            count_listBox.Items.Clear();

            // 重新分配陣列大小
            menu_datas = _Model.Show_Menu_Names();

            for (int i = 0; i < _Model.items_count; i++)
            {
                menu_listBox.Items.Add(menu_datas[i]);
                count_listBox.Items.Add(0);
            }
        }


        // 快捷鍵
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // B 鍵 -> 後臺管理系統
            if (keyData == Keys.B )
            {
                bms_ts_button_Click(null, null);
            }

            return base.ProcessDialogKey(keyData);
        }

        // 關閉視窗
        private void Order_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Model.Export_Menu();

            if (MessageBox.Show("即將關閉，是否繼續？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;  //關閉視窗
            }
            else
            {
                e.Cancel = true;    //取消關閉
            }
        }


    }
}
