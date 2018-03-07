using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            string name;
            int maxNameLetters = 10;
            Console.Write("Enter your name? max letters:10 => ");
            name = Console.ReadLine();
            if(name.Length > maxNameLetters || name.Length == 0)
            {
                Console.WriteLine("Invalid name- use max letters of 10");
            }
            else
            {
                Console.WriteLine("Thanks, {0}", name.ToUpper());
            }

        }
    }
}
