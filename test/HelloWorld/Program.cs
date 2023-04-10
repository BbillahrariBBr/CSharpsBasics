using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string userName = Console.ReadLine();

            Console.Write("Please Enter Your Age: ");
            string userAge = Console.ReadLine();

            Console.WriteLine("Hello "+ userName + " Your age is "+  userAge);

            // integer input

            int num1, num2;
            Console.Write("Enter first number: ");
            string inputNum1 = Console.ReadLine();

            Console.Write("Enter Second number: ");
            string inputNum2 = Console.ReadLine();

            // string to int convert
            num1 = Convert.ToInt16(inputNum1);
            num2 = Convert.ToInt16(inputNum2);

            int result = num1*num2;

            Console.WriteLine(result);


        }
    }
}
