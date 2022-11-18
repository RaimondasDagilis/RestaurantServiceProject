using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Classes
{
    internal class Order
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int GuestCount { get; set; }
        public DateTime Created { get; set; }
        public List<MenuItem> orderedMeals { get; set; }

    }
}
