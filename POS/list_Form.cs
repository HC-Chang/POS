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



        // 資料匯入
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



        // 確認 button
        private void confirm_button_Click(object sender, EventArgs e)
        {
            List<int> selected_indices = GetCheckedIndices();

            if (selected_indices == null)
            {
                this.Close();
                return;
            }

            /*********************/
            // bug

            // Remove
            if (!RorM)
            {
                string delete_data_string = "確定刪除資料？\n\n";

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    delete_data_string += checkedListBox1.Items[i].ToString() + "\n";
                }

                if (MessageBox.Show(delete_data_string, "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 刪除資料
                    model.Remove_Menu(selected_indices);

                    // 關閉表單
                    this.Close();
                }

                selected_indices.Clear();
            }
            // Modify
            else
            {

            }

           

            
        }

        // 重新設定項目 button
        private void reset_button_Click(object sender, EventArgs e)
        {
            List<int> indices = GetCheckedIndices();
            for (int i = 0; i < indices.Count; i++)
            {
                checkedListBox1.SetItemChecked(indices[i], false);
            }
            checkedListBox1.ClearSelected();
        }

        // 取消 button
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Get Checked Indices
        private List<int> GetCheckedIndices()
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }
            return indices;
        }
    }
}
