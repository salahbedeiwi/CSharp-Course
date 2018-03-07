using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask questions
            Console.Write("Enter first number: => ");
            int num1 = int.Parse(Console.ReadLine()); //convert str -> int
            Console.Write("Enter second number: => ");
            int num2 = Int32.Parse(Console.ReadLine());//convert str -> int
            Console.WriteLine("---------------------------");

            //now validate inputs
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} is equal to {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} is less than {1}", num1, num2);
            }

            Console.WriteLine("---------------------------");            
            //now if we divide by 0, it will give us exception divideByZero error
            if(num1 == 0 || num2 == 0)
            {
                Console.WriteLine("can't enter 0!");
            }
            else
            { //if none of num2 or num1 is 0, then divide
                double r = ((double)num1 / (double)num2); //note num1 & num2 are int, 
                // so convert to double by casting them
                Console.WriteLine("The division of {0}/{1} is {2}", num1, num2, r); //show results as double
            }
            Console.WriteLine("---------------------------");
            Console.Write("Enter word 1: => ");
            string word1 = Console.ReadLine();
            Console.Write("Enter word 2: => ");
            string word2 = Console.ReadLine();
            Console.WriteLine("---------------------------");
            if (word1 == word2)
                Console.WriteLine("'{0}' is the same as '{1}'", word1, word2);
            else
                Console.WriteLine("'{0}' is not the same as '{1}'", word1, word2);
            Console.WriteLine("---------------------------");
        }
    }
}
