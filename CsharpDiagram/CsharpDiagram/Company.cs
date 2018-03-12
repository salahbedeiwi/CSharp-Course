using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyNameSpace
{
    public class Company : CsharpDiagram.ManagmentOffice
    {
        private static int id;
        private static string name;
        public string BestName;
        public static int Id { set { id = value; } get { return id; } }
        public static string Name { set { name = value; } get { return name; } }
        /// <summary>
        /// This is to print Company Info
        /// </summary>
        /// <remarks>Print Company Info.. Must have both company name and id.</remarks>
        public static void Print()
        {
            name = Name; id = Id;
            Console.WriteLine("Your Name is {0}!\nId is {1}.", name, id);
        }
        public Company() { Console.WriteLine("Init... Company Class"); }
        ~Company() { Console.WriteLine("Finishing... Company Class"); }
    }
}