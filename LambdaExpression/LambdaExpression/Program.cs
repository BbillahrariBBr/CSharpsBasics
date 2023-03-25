using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    //define
    public delegate string greetDele(string name);
    internal class Program
    {
        static void Main(string[] args)
        {

            //greetDele greet = new greetDele(AnnonymousMethods.Greetings);
            //lambda expression
            greetDele greet =  (name) =>
            {
                return "Hello " + name + " have a good day!";
            };

            //greetDele greet = delegate (string name)
            //{
            //    return "Hello " + name + " have a good day!";
            //};


            var output = greet.Invoke("baki");
            Console.WriteLine(output);

        }
    }
}
