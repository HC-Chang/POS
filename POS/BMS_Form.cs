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
        public Order_Form of3;
        string s = "";

        private void new_menu_button_Click(object sender, EventArgs e)
        {
           

            KeyInForm kif;
            kif= new KeyInForm("品項");
            kif.ShowDialog();
            s += kif.key_in_textBox.Text + ",";
            kif = new KeyInForm("價錢");
            kif.ShowDialog();
            s += kif.key_in_textBox.Text;

            text_Form t_f = new text_Form(s);
            t_f.Show();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            of3.label1.Text = s;
            this.Close();
        }
    }
}
