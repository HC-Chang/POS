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
    }
}
