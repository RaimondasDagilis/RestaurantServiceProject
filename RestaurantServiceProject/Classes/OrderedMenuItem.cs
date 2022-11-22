using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Classes
{
    public class OrderedMenuItem : MenuItem
    {
        public int Amount { get; set; }
        public OrderedMenuItem(int id, string name, string description, decimal price) : base(id, name, description, price)
        {
            Amount = 1;
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
