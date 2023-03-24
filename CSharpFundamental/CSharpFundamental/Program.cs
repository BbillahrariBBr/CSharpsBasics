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
            Person person = new Person();
            person.firstName = "Baki";
            person.lastName = "Billah";
            person.Introduce();
            Console.ReadLine();
        }
    }
}
