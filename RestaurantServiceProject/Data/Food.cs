using RestaurantServiceProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Data
{
    internal class Food
    {
        public List<MenuItem> FoodList { get; set; }
        public string FileName { get; set; }
        public Food()
        {
            FoodList = new List<MenuItem>();
            string[] lines = File.ReadAllLines("txt_files/food.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split("|");
                FoodList.Add(new MenuItem(int.Parse(data[0]), data[1], data[2], decimal.Parse(data[3])));
            }
        }
    }
}
