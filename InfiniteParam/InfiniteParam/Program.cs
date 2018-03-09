using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteParam
{
    //class accepts many parameters
    //create a method that takes as many as numbers and add them

    class Program
    {
        static void PL(int n) {
            string x = "";
            for(int f = 0; f < n; f++)
            {
                x += "=";
            }
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int[] x = new int[] { 12, 12, 12, 12, 12, 12 };
            int z = MyMath.SumAnyParam(x);
            Console.WriteLine("Total is {0}", z);
            PL(80);

            int[] x32 = new int[] { 2, 1, 3, 4, 5, 6 };
            int z32 = MyMath.SumAnyParam(x32);
            Console.WriteLine("Total is {0}", z32);
            PL(80);

            Console.WriteLine("Sum is {0}", MyMath.SumParam(15, 16));
            Console.WriteLine("Sum is {0}", MyMath.SumParam(15, 16, 152));
            PL(80);

            //use params keyword, easiest
            Console.WriteLine("Sum is => " + 
                                    MyMath.SumOfAll(15, 32, 32, 32, 120, 326, 32));
            PL(80);
            Console.WriteLine("Sum is => " +
                                    MyMath.SumOfAll(15));
            Console.WriteLine("===================================");
            Console.WriteLine("Sum is => " +
                                    MyMath.SumOfAll(15, -32, +32));
            Console.WriteLine("===================================");
            //i can also pass an array
            Console.WriteLine("Sum is => " +
                                    MyMath.SumOfAll(new int[] { 2, 1, 3, 4, 5, 6 }));
            Console.WriteLine("===================================");
            Console.WriteLine("Sum is => " +
                                    MyMath.SumOfAll(z32)); //pass array
            PL(80);
            //note, i can pass any variables as string as well
            Console.WriteLine("String of full name: {0}"
                                , MyMath.ConcatinateString("Salah", "Imad", "Bedeiwi"));
            PL(40+40);
            Console.ReadKey();
        }
    }
}
/* Answers:
 Total is 72
================================================================================
Total is 21
================================================================================
Sum is 31
Sum is 183
================================================================================
Sum is => 589
================================================================================
Sum is => 15
===================================
Sum is => 15
===================================
Sum is => 21
===================================
Sum is => 21
================================================================================
String of full name: Salah Imad Bedeiwi
================================================================================


*/
