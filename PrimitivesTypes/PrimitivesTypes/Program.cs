using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivesTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringVar = "Hello World";
            int intVar = 100;
            float floatVar = 100.2f;
            char  charVar = 'a';
            bool boolVar = false;

            var firstName = "Baki";
            var lastName = "Billah";

            var fullName = firstName + lastName;
            var firstNumber = 5;
            var secondNumber = 10;
            var sum = firstNumber+secondNumber;
            Console.WriteLine(sum);

            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}
