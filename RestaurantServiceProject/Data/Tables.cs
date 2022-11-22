using RestaurantServiceProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Data
{
    public class Tables
    {
        public List<Table> TableList { get; set; }
        private string FileName { get; set; }
        public Tables()
        {
            TableList = new List<Table>();            
            string[] lines = File.ReadAllLines("txt_files/tables.txt");
            foreach (string line in lines)
            {
                string[] intArray = line.Split(" ");
                TableList.Add(new Table(int.Parse(intArray[0]), int.Parse(intArray[1])));
            }
        }
    }
}
