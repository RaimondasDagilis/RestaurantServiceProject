using RestaurantServiceProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Data
{
    public class Drinks
    {
        private List<MenuItem> DrinksList { get; set; }
        private string FileName { get; set; }
        public Drinks()
        {
            DrinksList = new List<MenuItem>();
            string[] lines = File.ReadAllLines("txt_files/drinks.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split("|");
                DrinksList.Add(new MenuItem(int.Parse(data[0]), data[1], data[2], decimal.Parse(data[3])));
            }
        }
    }
}
