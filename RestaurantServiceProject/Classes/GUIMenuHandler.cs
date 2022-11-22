using RestaurantServiceProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Classes
{
    public static class GUIMenuHandler
    {        
        public static void Init(Tables tables)
        {
            int tableId = 0;
            int menu = 0;
            GUI.DrawGUI("default", tables);
            int selectedMenu = int.Parse(Console.ReadLine());
            switch (selectedMenu)
            {
                case 1:
                    Console.Clear();
                    tableId = GUI.DrawGUI("select_free_table", tables);
                    menu = GUI.DrawGUI("place_order", tables);
                    if (menu == 1)
                    {
                        GUI.DrawGUI("select_food", tables);
                    }
                    else if (menu == 2)
                    {
                        GUI.DrawGUI("select_drinks", tables);
                    }                        
                    break;
                case 2:
                    Console.Clear();
                    tableId = GUI.DrawGUI("select_taken_table", tables);
                    break;
                default:
                    break;
            }
        }
    }
}
