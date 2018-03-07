using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //array example - loop through an array
            object[] names = new object[5];
            names[0] = "Salah";
            names[1] = "Ahmed";
            names[2] = "Mohsin";
            names[3] = "Samir";
            names[4] = "Bedeiwi";
            int countNames = names.Count(); //5
            //print all the values
            Console.WriteLine("Number of names: {0} elements/names!", countNames);
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name #{0} => {1}", i, names[i]);
            }
            //example:
            Console.WriteLine("========================");
            Console.Write("Enter count of Employees => ");
            int empCount = int.Parse(Console.ReadLine());
            string[] empNames = new string[empCount];

            for(int i = 0; i < empCount; i++)
            {
                Console.Write("Enter Employee Name #{0} => ", i+1); //enter every name:, +1 so employee-1
                empNames[i] = Console.ReadLine();//add the answer on the array
            }
            //now print the employees
            for(int x = 0; x < empNames.Length; x++)
            {
                Console.WriteLine("Employee Name #{0}-{2} => {1}", x+1, empNames[x], empNames.Length);
            }
        }
    }
}
