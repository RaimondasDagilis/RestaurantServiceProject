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
        public DateTime Created { get; set; }
        public List<OrderedMenuItem> orderedFood { get; set; }
        public List<OrderedMenuItem> orderedDrinks { get; set; }
        public Order(int tableId)
        {            
            TableId = tableId;
            orderedFood = new List<OrderedMenuItem>();
            orderedDrinks = new List<OrderedMenuItem>();
            Created = DateTime.Now;
        }
        public void AddFoodOrDrink(int foodOrDrink, MenuItem item)
        {
            List<OrderedMenuItem> list;
            if ((foodOrDrink == 1))
            {
                list = orderedFood;
            }
            else
            {
                list = orderedDrinks;
            }
            OrderedMenuItem _item = list.Find(x => x.Id.Equals(item.Id));
            if (_item != null)
            {
                _item.Amount++; 
            } else
            {
                _item = new OrderedMenuItem(item.Id, item.Name, item.Description, item.Price);
                list.Add(_item);
             };
        }

    }
}
