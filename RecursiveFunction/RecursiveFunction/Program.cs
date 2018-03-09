using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    //class that have a recursive function:
    //factorical: n! => 3! => 3*2*1 is 6
    class MyMath
    {
        public static int Factorial(int num)
        {
            if (num == 0) return 1; //0! = 1
            else return num * Factorial(num - 1);
            //note i can call same method inside
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = MyMath.Factorial(3);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
