using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Classes
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } //Meat, fish, vegan, soft drink, alko, hot drink... 
        public MenuItem(string name, string description, int price, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }
    }
}
