using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class A3 : BMW
    {
        public A3(int hp, string color, string model):base(hp,color, model)
        {
            
        }

        public override void Repair()
        {
            Console.WriteLine("The {0} car was repaired", Model);
        }
    }
}
