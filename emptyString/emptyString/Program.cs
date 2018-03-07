using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emptyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.Write("Enter your name => ");
            string name = Console.ReadLine();
            //string name = Console.ReadLine().Trim();
            //NOTE I USED TRIM, i COULD ALSO TRIM BEFORE validating
            if (name.Length == 0 || name.Length < 1 || name == "" || name.Trim() == "")
                Console.WriteLine("Can't be empty name!");
            else 
                Console.WriteLine("Thanks {0}!", name);
            Console.WriteLine("==============================");
            //another way
            if (name == string.Empty)
            {
                Console.WriteLine("Can't be empty name! => string");
            }
            //another way
            if(name == null) //if only  defined as => string name = null
            {
                Console.WriteLine("Can't be empty name => null!");
            }
            //another way
            if (string.IsNullOrEmpty(null))
            {
                Console.WriteLine("Can't be empty name => IsNullOrEmpty(null)!");
            }
        }
    }
}
