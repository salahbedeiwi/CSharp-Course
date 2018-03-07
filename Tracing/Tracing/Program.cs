using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            //how to trace my program step by step
            string n;
            n = "Bedeiwi";
            Console.WriteLine(n);
            Console.WriteLine("==============");
            string[] names = { "Salah", "Ahmed", "Mohamed", "Latifa" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==============");
        }
    }
}
