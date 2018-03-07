using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop:
            Console.WriteLine("===============================================");
            Console.WriteLine("print 1-10 and show even/odd numbers by console");
            Console.WriteLine("===============================================");
            //print 1-10
            Console.WriteLine("1\n2\n3\n4\n5\n6\n7\n8\n9\n10");
            Console.WriteLine("===============================================");
            int length = 10;
            //loop:
            Console.WriteLine("print 1-10 and show even/odd numbers");
            Console.WriteLine("===============================================");
            for (int i = 1; i <= length; i++)
            {
                //if even
                if (i%2 == 0) //if no remainder, means it is even
                    Console.WriteLine("{0} => even", i);
                //if odd or have a remainder greater than 1, it is odd
                else
                    Console.WriteLine("{0} => odd", i);

            }
            Console.WriteLine("===============================================");
            Console.WriteLine("Print from a => z");
            Console.WriteLine("===============================================");
            for (char characters = 'a'; characters <= 'z'; characters++)
            {
                //print it as letter => decimal number 
                Console.WriteLine("Letter => {0} => {1}", characters, (int)characters); 
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("Print from B => M");
            Console.WriteLine("===============================================");
            for (char characters1 = 'B'; characters1 <= 'M'; characters1++)
            {
                //print it as letter => decimal number 
                Console.WriteLine("Letter => {0} => {1}", characters1, (int)characters1);
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("Advanced Examples"); //many variables on for loop
            Console.WriteLine("===============================================");
            for(int x = 1, y = 10, z = 100; x <= 10; x++, y--, z += 10)
            {
                Console.WriteLine("x => {0} | y => {1} | z => {2}", x, y, z);
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("===============================================");
            Console.WriteLine("Advanced Examples"); //many variables on for loop
            Console.WriteLine("===============================================");
            for (int x = 1, y = 10; x < y ; x++, y--)
            {
                Console.WriteLine("x => {0} | y => {1}", x, y);
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("===============================================");
            Console.WriteLine("Advanced Examples - inifinite loop"); //inifinite loop
            //for (int x = 1; x >= 1; x++)
            //{
            //    Console.WriteLine("x => {0} ", x);
            //}
            Console.WriteLine("===============================================");
            Console.WriteLine("Inifinite lopp");
            Console.WriteLine("===============================================");
            for (;;)
            {
                Console.Write("101");
            }
        }
    }
}
