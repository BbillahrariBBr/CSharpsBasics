using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public string name;
        public int age;
        public string color;

        public void printDetails()
        { Console.WriteLine("Name: " + name + " Age: " + age + " Color: " + color); }
    }

    class Dog : Animal {
        public string bred;

        public void sound()
        {
            Console.WriteLine("Dog Sound: Ghew Ghew");
        }

        public Dog(string _name, int _age, string _color, string _bred) {
            name = _name;  
            age = _age; 
            color = _color; 
            bred = _bred;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Audi", 5, "grey", "bangla");

            dog.printDetails();
            dog.sound();

        }
    }
}
