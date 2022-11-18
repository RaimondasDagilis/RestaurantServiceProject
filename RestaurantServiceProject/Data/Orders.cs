using RestaurantServiceProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Data
{
    internal class Orders
    {
        List<Order> orderList { get; set; }
        public Orders()
        {
            orderList = new List<Order>();
        }
    }
}
