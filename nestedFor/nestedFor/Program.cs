using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            for(int x = 1; x <= 3; x++)
            {
                Console.WriteLine("#"+x);
                //i want to add for loop inside a for loop
                for (int y = 1; y <= x; y++)
                {
                    Console.WriteLine("\tx" + x + " >>>>> y" + y);
                    for (int z = 1; z <= y; z++)
                    {
                        Console.WriteLine("\t\ty" + y + " >>>>> z" + z);
                    }
                }
            }
            Console.WriteLine("=============================================");
        }
    }
}
