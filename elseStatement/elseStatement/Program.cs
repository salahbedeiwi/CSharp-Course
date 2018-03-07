using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter word 1: => ");
            string word1 = Console.ReadLine();
            Console.Write("Enter word 2: => ");
            string word2 = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            if (word1 == word2)
                Console.WriteLine("'{0}' is the same as '{1}'", word1, word2);
            else
                Console.WriteLine("'{0}' is not the same as '{1}'", word1, word2);
            Console.WriteLine("-----------------------------------");
        }
    }
}
