using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Animal
    {
        public string name ;
        public int age;
        public string voice;
        public static int animalCount = 0;

        public void printDetails()
        {
            Console.WriteLine("Name " + name + " Age " + age + " Voice " + voice);
        }
        public Animal(string _name, int _age, string _voice)
        {
            name = _name;
            age = _age;
            voice = _voice;

            animalCount++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Tiger",7,"Ghew");
            dog.printDetails();
            Animal cat = new Animal("Tom", 4, "Mew");
            cat.printDetails();
            Console.WriteLine(Animal.animalCount);
            Console.ReadLine();
        }
    }
}
