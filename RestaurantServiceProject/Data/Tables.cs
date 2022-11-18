using RestaurantServiceProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Data
{
    internal class Tables
    {
        public List<Table> TableList { get; set; }
        private string FileName { get; set; }
        public Tables()
        {
            //Implementuot staliuku nuskaityma
        }
    }
}
