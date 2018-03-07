using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name? => ");
            string str = Console.ReadLine();
            //how to replace a string, or anything on a string
            string strClear = str.Replace(';', '*');

            Console.WriteLine("you entered {0}", str);
            Console.WriteLine("replace ; with * => {0}", strClear);
            Console.WriteLine("================================");
            //say your username doesn't accept any space
            Console.Write("Enter your name? => ");
            str = Console.ReadLine();
            //how to replace a string, or anything on a string
            strClear = str.Replace(" ", ""); //replace space with empty string
            //no spaces
            Console.WriteLine("you entered {0}", str);
            Console.WriteLine("replace space with empty string => {0}", strClear);

        }
    }
}
