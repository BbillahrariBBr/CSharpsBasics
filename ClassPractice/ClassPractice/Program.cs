using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Animal
    {
        public string name = "Tiger";
        public int age = 6;
        public string voice = "Ghew";

        public void printDetails()
        {
            Console.WriteLine("Name " + name + " Age " + age + " Voice " + voice);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.printDetails();
            Animal cat = new Animal();
            cat.name = "Tom";
            cat.age = 5;
            cat.voice = "Mew";
            cat.printDetails();

            Console.ReadLine();
        }
    }
}
