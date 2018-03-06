using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsNonStatic
{
    class Program
    { 
        static void Main(string[] args)
        {
            //here i can only see the static attributes, methods directly
            Person.name = "SASD";
            Person.justCALLMe();

            //non static methods, i must declare an obj
            Person p1 = new Person();
            p1.address = "361 81st Ave NE";
            p1.id = 150;
            p1.PrintData();
            p1.printName();
            
            
            Console.ReadKey();

        }
    }
}
