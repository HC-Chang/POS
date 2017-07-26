using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace POS
{
    public class pos_model
    {
        // type name price
        // 種類 項目 金額
        List<c_menu_item> l_menu_items = new List<c_menu_item>();
        public  int items_count = 0;


        // 匯入菜單項目
        public void Import_Menu()
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
            while (!sr.EndOfStream)
            {
                if ((temp = sr.ReadLine()) == "")
                {
                    continue;
                }
                temps = temp.Split(',');
                
                // 增加菜單項目
                Add_Menu(temps[0], temps[1], temps[2]);

            }
            sr.Close();
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
                temp += l_menu_items[i].type+ ","+ l_menu_items[i].name + "," + l_menu_items[i].price + "\n";
            }


         //       File.WriteAllText("config/menu.pos", temp);
            StreamWriter sw = new StreamWriter("config/menu.pos");
            sw.Write(temp);
            sw.Close();

        }



        // 顯示菜單類型
        public string[] Show_Menu_Types()
        {
            string[] show_data;
            if (items_count < 1)
            {
                show_data = new string[1];
                show_data[0] = "無資料";
                return show_data;
            }
            show_data = new string[items_count];
            for (int i = 0; i < items_count; i++)
            {
                show_data[i] = l_menu_items[i].type.ToString();
            }
            return show_data;
        }

        // 顯示菜單項目
        public string [] Show_Menu_Names()
        {
            string[] show_data;
            if (items_count < 1)
            {
                show_data = new string[1];
                show_data[0] = "無資料";
                return show_data;
            }
            show_data = new string[items_count];
            for (int i = 0; i < items_count; i++)
            {
                show_data[i] = l_menu_items[i].name;
            }
            return show_data;
        }

        // 顯示菜單價格
        public string[] Show_Menu_Prices()
        {
            string[] show_data;
            if (items_count < 1)
            {
                show_data = new string[1];
                show_data[0] = "無資料";
                return show_data;
            }
            show_data = new string[items_count];
            for (int i = 0; i < items_count; i++)
            {
                show_data[i] = l_menu_items[i].price.ToString();
            }
            return show_data;
        }



        // 增加菜單項目
        public void Add_Menu(string t, string n, string p)
        {
            if(l_menu_items == null)
            {
                l_menu_items = new List<c_menu_item>();
            }

            int err = -1;
            if (int.TryParse(t, out err) && int.TryParse(p, out err))
            {
                l_menu_items.Add(new c_menu_item(t, n, p));
            }
            items_count = l_menu_items.Count;
        }
        
        // 移除菜單像目
        public void Remove_Menu(int [] r_indeices)
        {
            if(r_indeices == null)
            {
                return;
            }

            for (int i = r_indeices.Length-1 ; i>-1 ;i--)
            {
                l_menu_items.RemoveAt(r_indeices[i]);
            }

            items_count = l_menu_items.Count;
        }

        // 修改菜單項目
        public void Modify_Menu(int i,string t, string n, string p)
        {
            if(l_menu_items[i] == null)
            {
                MessageBox.Show("修改項目有誤！！！", "錯誤");
                return;
            }

            l_menu_items[i] = new c_menu_item(t,n,p);
        }

       
        // type name price
        // 種類 項目 金額
        public class c_menu_item
        {
            public int type { get; set; }
            public string name { get; set; }
            public int price { get; set; }

            public c_menu_item(string t,string n, string p)
            {
                type = Convert.ToInt16(t);
                name = n;
                price = Convert.ToInt32(p);
            }
        }
    }
}
