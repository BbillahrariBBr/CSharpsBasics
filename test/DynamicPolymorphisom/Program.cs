using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphisom
{
    // method overriding

    class University
    {
        protected double Uid;
        protected string UName;

        virtual public void Show()
        {
            Console.WriteLine("University Id: " + Uid);
            Console.WriteLine("Universtity Name: " + UName);
        }

    }

    class Department : University
    {
        protected double Did;
        protected string DName;

        public Department(double UidInput, string UNameInput, double DidInput, string DNameInput)
        {
            base.Uid = UidInput;
            base.UName = UNameInput;
            Did = DidInput;
            DName = DNameInput;
            
        }
        override public void Show()
        {
            base.Show();
            Console.WriteLine("Department Id: " + Did);
            Console.WriteLine("Department Name: " + DName);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dp = new Department(438, "UIU", 55,"CSE");
            dp.Show();
        }
    }
}
