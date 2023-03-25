﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW(200,"Black", "A3"),
            new Audics(100, "Red", "z3"),
            };

            foreach (var car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }
        }
    }
}
