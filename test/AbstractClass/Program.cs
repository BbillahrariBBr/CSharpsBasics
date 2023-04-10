using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Calculator
    {
        public void Addition(double inp1, double inp2)
        {
            Console.WriteLine(inp1+ inp2);    
        }
        public void Subtraction(double inp1, double inp2)
        {
            Console.WriteLine(inp1 - inp2);
        }
        abstract public void Division(double inp1, double inp2);
        abstract public void Multiplication(double inp1, double inp2);
    }

    class ScientificCalculator : Calculator
    {
        public override void Division(double inp1, double inp2)
        {
            Console.WriteLine(inp1 / inp2);
        }
        public override void Multiplication(double inp1, double inp2)
        {
            Console.WriteLine(inp1 * inp2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            
            ScientificCalculator calculator = new ScientificCalculator();
            Calculator cobjref = calculator; // ref of abstractCalass
            cobjref.Addition(5, 7);
            cobjref.Subtraction(15,28);
        }
    }
}
