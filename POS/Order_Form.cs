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
        BMS_Form bms_form = new BMS_Form();

        public List<Menu> l_menu = new List<Menu>();
        
        public Order_Form()
        {
            InitializeComponent();
            bms_form.of3 = this;
        }

        #region tool strip button

        private void bms_ts_button_Click(object sender, EventArgs e)
        {
            bms_form.ShowDialog();
        }

        #endregion

        public class Menu
        {
            public string name { get; set; }
            public int price { get; set; }
        }

        private void menu_listBox_MouseDown(object sender, MouseEventArgs e)
        {
            // 品項增加
            if (e.Button == MouseButtons.Left)
            {
                count_listBox.Items[menu_listBox.SelectedIndex] = (Convert.ToInt16(count_listBox.Items[menu_listBox.SelectedIndex].ToString()) + 1).ToString();
            }

            // 品項減少
            if (e.Button == MouseButtons.Right && Convert.ToInt16( count_listBox.Items[menu_listBox.SelectedIndex].ToString())>0)
            {
                count_listBox.Items[menu_listBox.SelectedIndex] = (Convert.ToInt16(count_listBox.Items[menu_listBox.SelectedIndex].ToString()) - 1).ToString();
            }
        }

    }
}
