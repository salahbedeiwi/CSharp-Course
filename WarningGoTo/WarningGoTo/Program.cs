using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarningGoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            start:; //i customed something that i can go back at any tim
            Console.WriteLine( "Enter your name => ");
            string name = Console.ReadLine();
            Console.WriteLine( "Your name is {0}", name );
            //ask him if we need to enter your name again?
            Console.WriteLine("Enter your name again => (y/n)");
            char c = Console.ReadLine()[0]; //get first 1 char only
            if (c == 'y' || c == 'Y') goto start;
            Console.ReadKey();

        }
    }
}
