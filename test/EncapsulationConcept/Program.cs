using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationConcept
{
    class Calcultor
    {
        private double x, y;
        public Calcultor(double input1, double input2)
        {
            x = input1;
            y = input2;
            
        }
        private double multiplication()
        {
            return x * y;
        }

        public void displayResult()
        {
            Console.WriteLine("Multiplicaton Result " + multiplication());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double input1, input2;
            Console.Write("Enter First Number: ");
            input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            input2 = Convert.ToDouble(Console.ReadLine());

            Calcultor calcultor = new Calcultor(input1, input2);
            calcultor.displayResult();

        }
    }
}
