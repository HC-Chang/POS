using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class list_Form : Form
    {
        string[] menu_datas;
        pos_model model;

        // Remove -> flase
        // Modify -> True
        bool RorM;

        // KeyIn Form
        KeyInForm kif;
        string[] adds = new string[] { "種類", "品項", "價錢" };
        string[] keep_datas = new string[3];



        // 初始化 -> 資料匯入
        public list_Form(pos_model _Model,bool _RorM)
        {
            InitializeComponent();

            model = _Model;
            RorM = _RorM;

            // Remove
            if(!RorM)
            {
                this.Text = "刪除";
            }
            // Modify
            else
            {
                this.Text = "修改";
            }
            

            menu_datas = model.Show_Menu_Names();

            for (int i = 0; i < model.items_count;i++)
            {
                checkedListBox1.Items.Add(menu_datas[i]);
            }
                     
        }



        #region button

        // 確認 button
        private void confirm_button_Click(object sender, EventArgs e)
        {
            int [] selected_indices = GetCheckedIndices();

            if (selected_indices == null)
            {
                this.Close();
                return;
            }

            // Remove
            if (!RorM)
            {
                string delete_data_string = "確定刪除資料？\n\n";

                for (int i = 0; i < selected_indices.Length; i++)
                {
                    delete_data_string += checkedListBox1.Items[selected_indices[i]].ToString() + "\n";
                }

                if (MessageBox.Show(delete_data_string, "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 刪除資料
                    model.Remove_Menu(selected_indices);

                    // 關閉表單
                    this.Close();
                }

            }

            // Modify
            else
            {
                // 清除資料
                KIF_clean_data();

                // 增加資料
                KIF_add_data();

                // 確認資料
                if (!kif.IfCancel)
                {
                    // 修改資料
                    model.Modify_Menu(selected_indices[0], keep_datas[0], keep_datas[1], keep_datas[2]);
                }

                this.Close();

            }
      
        }

        // 取消 button
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 重新設定項目 button
        private void reset_button_Click(object sender, EventArgs e)
        {
            int[] indices = GetCheckedIndices();
            for (int i = 0; i < indices.Length; i++)
            {
                checkedListBox1.SetItemChecked(indices[i], false);
            }
            //checkedListBox1.ClearSelected();
        }

        #endregion



        // Get Checked Indices
        private int [] GetCheckedIndices()
        {
            int [] index ;
            List<int> indices = new List<int>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }

            index = indices.ToArray();
            return index;
        }

        // 單選機制
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Modify
            if (RorM)
            {
                reset_button_Click(sender, e); 
            }
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

                if(kif.IfCancel == true)
                {
                    return;
                }
            }
        }

        #endregion
    }
}
