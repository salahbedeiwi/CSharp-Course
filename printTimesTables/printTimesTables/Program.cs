using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printTimesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // print times table from 1-10
            for(int baseNum = 1; baseNum <= 10; baseNum++)
            {
                Console.WriteLine("Table #{0}", baseNum);
                Console.WriteLine("-------");
                for(int num = 1; num <= 10; num++)
                {
                    Console.WriteLine("{0} * {1} = {2}", baseNum , num, baseNum*num);
                }
                Console.WriteLine("===========");
            }
            for (int baseNum = 1; baseNum <= 10; baseNum++)
            {
                Console.WriteLine("Table #{0}", baseNum);
                Console.WriteLine("-------");
                for (int num = baseNum; num <= 10; num++)
                {
                    Console.WriteLine("{0} * {1} = {2}", baseNum, num, baseNum * num);
                }
                Console.WriteLine("===========");
            }
        }
    }
}
