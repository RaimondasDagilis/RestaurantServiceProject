using RestaurantServiceProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Classes
{
    public static class GUI
    {
        public static int DrawGUI(string selectGUI, Tables tables)
        {
            int selectedMenu = 0;
            switch (selectGUI)
            {
                case "select_free_table":
                    Console.WriteLine("Free tables at the moment : ");
                    PrintTables(tables.TableList.Where(table => table.IsFree == true).ToList());
                    selectedMenu = int.Parse(Console.ReadLine());
                    tables.TableList.Find(x => x.Id == selectedMenu).IsFree = false;
                    return selectedMenu;
                    break;
                case "select_taken_table":
                    Console.WriteLine("Taken tables at the moment : ");
                    PrintTables(tables.TableList.Where(table => table.IsFree == false).ToList());
                    selectedMenu = int.Parse(Console.ReadLine());
                    return selectedMenu;
                    break;
                case "place_order":
                    Console.WriteLine("1. Food\n2. Drinks\n3. Finish order");
                    selectedMenu = int.Parse(Console.ReadLine());                    
                    return selectedMenu;
                    break;
                case "select_food":
                    return selectedMenu;
                    break;
                case "select_drinks":
                    return selectedMenu;
                    break;
                case "taken_tables":
                    Console.WriteLine("1. Vacate table\n2. Update order\n 3.Print receipt");
                    return selectedMenu;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("1. Free tables\n2.Taken tables");
                    return selectedMenu;
                    break;
            }
        }
        private static void PrintTables(List<Table> tables)
        {
            foreach (Table table in tables)
            {
                Console.Write($"{table.Id}. {table.Seats} seats.");
            }
            Console.WriteLine("");
        }
    }
}
