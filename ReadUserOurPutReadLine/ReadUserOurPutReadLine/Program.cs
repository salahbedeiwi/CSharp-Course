using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadUserOurPutReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to read users input
            /*
             * ReadLine(): 
             * Read():
            */
            Console.WriteLine("=========Get Users Inputs=====");
            Console.WriteLine("===Ex===");
            // Ask user to enter something:
            Console.WriteLine("What's your name?");
            // Now ask users to enter a value:
            string userName = Console.ReadLine(); //now I am expecting a string
            // now print the entered value:
            Console.WriteLine("How old are you?");
            string readInp = Console.ReadLine(); //save users value on readInp variable
            Console.WriteLine("How many siblings do you have?");
            string siblingsStr = Console.ReadLine(); //read siblings as string
            //note if users enters a string, it will cause a problem: only int as expected below
            int siblingInt = Convert.ToInt32(siblingsStr); //convert sibling string to int
            Console.WriteLine("\n\t=> {0}, Your age is {1} years."
                                        + "\n\tYou have {2} siblings!" ,
                                            userName.ToUpper(), readInp, siblingInt);
            Console.Write("How your total cash savings? => ");
            string cashStr = Console.ReadLine();
            double cashSav = double.Parse(cashStr);
            Console.Write("How your total bank savings? => ");
            string bankStr = Console.ReadLine();
            double bankSav = double.Parse(bankStr);
            Console.Write("How your total business savings? => ");
            string businessStr = Console.ReadLine();
            double businessSav = double.Parse(businessStr);
            Console.WriteLine("\n\t{0}, Your total saving is: ${1}"
                                            ,userName.ToUpper()
                                            , (cashSav + bankSav + businessSav));







        }
    }
}
