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
        public list_Form(Object [] o)
        {
            InitializeComponent();

            string[] types = (string [])o[1];
            string[] names = (string[])o[2];
            string[] prices = (string[])o[3];

            for (int i =0; i<(int)o[0];i++)
            {
                checkedListBox1.Items.Add(types[i]+","+names[i]+","+prices[i]);
            }
        }
    }
}
