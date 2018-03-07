using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            int x = 1;
            while (x < 10)
            {
                Console.WriteLine("X => {0}",x);
                x++; 
            }
            Console.WriteLine("=========================================");
            //NOTE BELOW IS AN INFINITE LOOP, BUT I HAVE A CONDITION TO STOP THE LOOP AT 
            // SPECIFIC VALUE
            int y = 1;
            while (true)
            {
                Console.WriteLine("X => {0}", y);
                y++;
                if (y >= 10) break;
            }
            Console.WriteLine("=========================================");
        }
    }
}
