using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //delegate
    // defining delegate
    public delegate int AddDelegate(int x, int y);


    internal class Program
    { // delegate er jnno 3 step
        // define a delegate
        // delegate intantiate korte hobe, point of functuon k pass korte hobe

        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            //delegate intantiate 2nd step
            AddDelegate addNums = new AddDelegate(AddNums);
            var res = addNums(10, 470);
            Console.WriteLine(res);

        }
    }
}
