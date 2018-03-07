using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forMulitiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum, multiplyStartNum, multiplyEndNum;
            Console.Write("Enter the base number: ");
            baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the starting multiplying number: ");
            multiplyStartNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending multiplying number: ");
            multiplyEndNum = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================");
            for (int num = multiplyStartNum; num <= multiplyEndNum; num++)
            {
                string str;
                int r = num * baseNum;
                str = "=> "+baseNum + " * " + num +" => " + r;
                Console.WriteLine(str);
            }
            Console.WriteLine("=====================================");
        }
    }
}
