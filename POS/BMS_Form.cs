﻿using System;
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
        public Order_Form of;
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
            KIF_clean_data();

            // 新增菜單資料
            KIF_add_data();

            // 確認資料
            if(!kif.IfCancel)
            {
                // 資料進入資料庫
                model.Add_Menu(keep_datas[0], keep_datas[1], keep_datas[2]);
            }

        }

        // 刪除
        private void delete_menu_button_Click(object sender, EventArgs e)
        {
            lf = new list_Form(model,false);
            lf.ShowDialog();
        }

        // 修改
        private void modify_menu_button_Click(object sender, EventArgs e)
        {
            lf = new list_Form(model,true);
            lf.ShowDialog();
        }

        // 檢視
        private void inspect_menu_button_Click(object sender, EventArgs e)
        {
            // Inspect Form
            inspect_Form i_form = new inspect_Form();

            i_form.dataGridView1.Columns.Add("_index","編號");

            for (int i =0; i<adds.Length;i++)
            {
                i_form.dataGridView1.Columns.Add("_"+adds[i],adds[i]);
            }

            DataGridViewRowCollection rows = i_form.dataGridView1.Rows;
            string[] t = model.Show_Menu_Types();
            string[] n = model.Show_Menu_Names();
            string[] p = model.Show_Menu_Prices();

            for (int i =0; i<model.items_count;i++)
            {
                rows.Add(new object[] {i+1, t[i], n[i], p[i] });
            }
            i_form.ShowDialog();
        }

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
            of.display_data();
            
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
            if (keyData == Keys.D && !this.delete_menu_button.Focused)
            {
                delete_menu_button_Click(null, null);
            }

            // M 鍵 -> 修改
            if (keyData == Keys.M && !this.modify_menu_button.Focused)
            {
                modify_menu_button_Click(null, null);
            }

            // I 鍵 -> 檢視
            if (keyData == Keys.I && !this.inspect_menu_button.Focused)
            {
                inspect_menu_button_Click(null, null);
            }



            return base.ProcessDialogKey(keyData);
        }



        #region KeyInForm

        // 清除資料
        private void KIF_clean_data()
        {
            for (int i = 0; i < keep_datas.Length; i++)
            {
                keep_datas[i] = "";
            }
        }

        // 加入資料
        private void KIF_add_data()
        {
            for (int i = 0; i < adds.Length; i++)
            {
                kif = new KeyInForm(adds[i]);
                kif.ShowDialog();
                keep_datas[i] = kif.key_in_textBox.Text;

                if (kif.IfCancel == true)
                {
                    return;
                }
            }
        }

        #endregion



        // Form 載入
        private void BMS_Form_Load(object sender, EventArgs e)
        {
            // 初始化 model
            model = of._Model;
        }

       
    }
}
