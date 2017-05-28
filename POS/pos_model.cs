using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace POS
{
    class pos_model
    {
        // name price
        // 項目 金額
        List<c_menu_item> l_menu_items = new List<c_menu_item>();
        int items_count = 0;


        // 匯入菜單項目
        public void Inport_Menu()
        {
            // 確認檔案
            if (!File.Exists("config/menu.pos"))
            {
                StreamWriter sw = new StreamWriter("config/menu.pos");
                sw.Write("");
                sw.Close();

                MessageBox.Show("沒有菜單項目資料，\n系統已建立新的菜單項目資料","通知");
                return;
            }
            
            // 匯入資料
            StreamReader sr = new StreamReader("config/menu.pos");
            string temp;
            string[] temps;
            int o = -1;
            while (!sr.EndOfStream)
            {
                if ((temp = sr.ReadLine()) == "")
                {
                    continue;
                }
                temps = temp.Split(',');
                if (  int.TryParse(temps[1],out o)  )
                {
                    l_menu_items.Add(new c_menu_item(temps[0], temps[1]));
                }
            }
            items_count = l_menu_items.Count;
        }

        // 匯出菜單項目
        public void Export_Menu()
        {
            if (!File.Exists("config/menu.pos"))
            {
                MessageBox.Show("沒有菜單項目資料，無法匯出", "警告");
                return;
            }

            string temp = "";
            for (int i = 0; i < items_count; i++)
            {
                temp += l_menu_items[i].name + "," + l_menu_items[i].price + "\n";
            }

            StreamWriter sw = new StreamWriter("config/menu.pos");
            sw.Write(temp);
            sw.Close();
        }

        public class c_menu_item
        {
            public string name { get; set; }
            public int price { get; set; }

            public c_menu_item(string n, string p)
            {
                name = n;
                price = Convert.ToInt32(p);
            }
        }
    }
}
