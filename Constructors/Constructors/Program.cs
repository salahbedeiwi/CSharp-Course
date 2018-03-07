using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    //overloading methods
    class OverLoadingClass
    {
        private int id;
        private string name;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NAME
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //overloading methods as constructors
        public OverLoadingClass()
        {
            Console.WriteLine("You called overLoadingClass");
        }
        public OverLoadingClass(string n)
        {
            this.name = n;
            Console.WriteLine("{0}, You called overLoadingClass",n);
        }
        //overloading methods as regular methods:
        public string GetInfo(string name, int id)
        {
            return string.Format("Name is {0}. Id is {1}", name, id);
        }
        public string GetInfo(string name)
        {
            return string.Format("Name is {0}", name);
        }
        public string GetInfo(int id)
        {
            return string.Format("Id is {0}", id);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            OverLoadingClass ol = new OverLoadingClass();
            OverLoadingClass ol2 = new OverLoadingClass("Salah");
            ol2.ID = 150;
            ol2.NAME = "Salah";
            Console.WriteLine(ol2.GetInfo(ol2.ID));
            Console.WriteLine(ol2.GetInfo(ol2.NAME, ol2.ID));
            Console.WriteLine(ol2.GetInfo(ol2.NAME));
            Console.ReadKey();
        }
    }
}
