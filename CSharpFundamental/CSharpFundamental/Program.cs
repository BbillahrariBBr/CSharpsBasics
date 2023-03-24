using CSharpFundamental.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            //string firstname = "baki";
            //string lastname = "billah";
            //string fullname = string.concat(firstname, lastname);
            //console.writeline(fullname);
            //console.writeline(firstname.indexof('k'));

            //enum
            //    public enum MailDetails
            //{
            //    regulaMail = 1, regulaMail2 = 2,  regularAirMail= 15,
            //}
            //Console.ReadLine();
            //switch

            //var season = Season.Summer;
            //switch(season) { 
            //    case Season.Summer: Console.WriteLine();
            //        break;

            //}
            //for, while, do while, foreach

            int[] number = { 1, 2, 3 };
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


        }
    }
}
