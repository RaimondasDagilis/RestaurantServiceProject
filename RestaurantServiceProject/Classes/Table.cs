﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantServiceProject.Classes
{
    public class Table
    {
        public int Id { get; set; }
        public bool IsFree { get; set; }
        public int Seats { get; set; }
        public Table(int id, int seats)
        {
            Id = id; //Implementuot id
            Seats = seats;
            IsFree = true;
        }
    }
}
