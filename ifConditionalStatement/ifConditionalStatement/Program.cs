using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter num 1: => ");
            int num1, num2, greater;
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter num 2: => ");
            num2 = Int32.Parse(Console.ReadLine());
            /*
            if (num1 > num2)
                greater = num1;
            else
                greater = num2;
            */
            // I can abbreviate the above if else statement
            //variable = (condition)? "if true, return this" : "if not true, else, return this" ;
            greater = (num1 > num2) ? num1 : num2;
            //now "greater" will take the value of the returned value from the conditional statement
            Console.WriteLine("{0} is the greatest!", greater);
            Console.WriteLine("-----------------------------------");
            //conditional if statement statement.
            Console.Write("Enter name: ");
            string defaultName = Console.ReadLine();
            //string myName = (condition) ? "if condition is true" : if condition is false;
            string myName = (defaultName == "") ? "Default Name: Salah Bedeiwi" : defaultName;
            //save the returned value from above and store it on myName
            Console.WriteLine("Name is : " + myName);
            Console.WriteLine("-----------------------------------");
        }
    }
}
