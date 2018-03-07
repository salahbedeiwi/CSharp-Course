using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter num 1: => ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter num2 2: => ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            if (num1 == num2)
                Console.WriteLine("'{0}' is equal to '{1}'", num1, num2);
            else if (num1 > num2)
                Console.WriteLine("'{0}' is greater than '{1}'", num1, num2);
            else
                Console.WriteLine("'{0}' is less than '{1}'", num1, num2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Adding {0} and {1} is => {2}", num1, num2, num1 + num2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Muliplying {0} times {1} is => {2}", num1, num2, num1 * num2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Division {0} by {1} is => {2}", num1, num2, (double)num1 / (double)num2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Subtracting {0} from {1} is => {2}", num1, num2, num1 - num2);
            Console.WriteLine("-----------------------------------");
        }
    }
}
