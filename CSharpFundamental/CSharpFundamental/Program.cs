using CSharpFundamental.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamental
{
    public class Person {
        public string firstName;
        public string lastName;

        public void Introduce() {
            Console.WriteLine("My Name is " + firstName + " " + lastName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // class 
            /* Person person = new Person();
            person.firstName = "Baki";
            person.lastName = "Billah";
            person.Introduce();

            var result = Calculator.Add(13, 20);
            Console.WriteLine(result);
            Console.ReadLine(); */

            // array
            // string 
            string firstName = "Baki";
            string lastName = "Billah";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);
            Console.WriteLine(firstName.IndexOf('k'));
            Console.ReadLine();

        }
    }
}
