using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //delegate
    //define 
    public delegate void RectDelegate(double width, double height);


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

            Rectangle rectangle = new Rectangle();
            // delegate intantiate
            RectDelegate rectDelegate = new RectDelegate(rectangle.GetArea);
            rectDelegate += rectangle.GetPerimeter;
            
            rectDelegate.Invoke(17, 40);
        }
    }
}
