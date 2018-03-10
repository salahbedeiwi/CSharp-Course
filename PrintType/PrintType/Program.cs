using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintType
{
    class Program
    {
        //create a method to get the type of anything
        static void PrintType(object obj)
        {
            if (obj is int) Console.WriteLine("Integer");
            else if (obj is decimal) Console.WriteLine("Decimal");
            else if (obj is string) Console.WriteLine("String/Text");
            else if (obj is char) Console.WriteLine("Char/Text");
            else if (obj is bool) Console.WriteLine("Boolean");
            else if (obj is double || obj is float) Console.WriteLine("Float/Double");
            else Console.WriteLine(obj.GetType().Name);
        }
        static void Main(string[] args)
        {
            int i = 77;
            double d = 99.55;
            string s = "hi";
            char c = 'e';
            bool f = true;
            Console.WriteLine("==========================================");
            PrintType(f);
            PrintType(c);
            PrintType(s);
            PrintType(d);
            PrintType(i);
            Console.WriteLine("==========================================");
            Console.WriteLine(d.GetType().Name);
            Console.WriteLine(typeof(int));
            Console.WriteLine("==========================================");
            Console.ReadKey();
        }
    }
}
