using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class PrintName
    {
        private string name;
        //build override constructors
        public PrintName()
        {
            Console.WriteLine("You have created an empty/normal constructor method");
        }
        //method #2
        public PrintName(string name)
        {
            Console.WriteLine("{0}, You have created an constructor method with one arg.");
        }
        //method #3
        public PrintName(string name, int id)
        {
            Console.WriteLine("#{0}-{1},You have created method with 2 param",id,name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of class PrintName
            PrintName n1 = new PrintName();//method #1
            PrintName n2 = new PrintName();//method #2
            PrintName n3 = new PrintName();//method #3
        }
    }
}
