using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audics:Car
    {
        private string brand = "Audi";

        public string Model { get; set; }
        public Audics(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Brand " + brand + " HP " + HP + " Color " + Color);
        }
        public override void Repair()
        {
            Console.WriteLine("The {0} {1} car was repaired", brand, Model);
        }
    }
}
