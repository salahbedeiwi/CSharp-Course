using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do While loop:
            int x = 1;
            do {
                Console.WriteLine("x => {0}", x);
                x++;
            } while (x <= 10); // 1-10
            Console.WriteLine("=================================");
            int y = 1;
            do
            {
                Console.WriteLine("y => {0}", y);
                y++;
                if (y >= 11) break;
            } while (true); //it keep running till it reaches 11 and then stops
            Console.WriteLine("=================================");
            int z = 1;
            do
            {
                Console.WriteLine("Z => {0}", z);
                z++;
            } while (false); // note it is false, so only runs the code first time
            Console.WriteLine("=================================");
            // Example: keep adding two numbers
            do
            {
                int num1, num2, sum;
                Console.Write("Enter first number to add? => ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number to add? => ");
                num2 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2;
                Console.WriteLine("=================================");
                Console.WriteLine("The sum of {0} and {1} => {2}", num1, num2, sum);
                Console.WriteLine("=================================");
                Console.Write("Do you like to continue? [y/n] => ");
                char continueAsking = Convert.ToChar(Console.ReadLine());
                if (continueAsking == 'n') break;
                Console.WriteLine("=================================");
            } while (true);
            string strYN = "";
            do
            {
                int num1, num2, sum;
                Console.Write("2. Enter first number to add? => ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Enter second number to add? => ");
                num2 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2;
                Console.WriteLine("=================================");
                Console.WriteLine("2. The sum of {0} and {1} => {2}", num1, num2, sum);
                Console.WriteLine("=================================");
                Console.Write("2. Do you like to continue? [y/n] => ");
                strYN = Console.ReadLine();
                Console.WriteLine("=================================");
            } while (strYN == "Y" || strYN == "y");
            Console.WriteLine("=================================");
            // ask questions to add it up, but limit max questions to 10
            int max = 10;
            int x12 = 1;

            do
            {
                int num1, num2, sum;
                Console.Write("Q-{0}. Enter first number to add? => ", x12);
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Q-{0}. Enter second number to add? => ", x12);
                num2 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2;
                Console.WriteLine("=================================");
                Console.WriteLine("Ans-{3}. The sum of {0} and {1} => {2}", num1, num2, sum, x12);
                Console.WriteLine("=================================");
                if (x12 == 10) Console.WriteLine("You have reached max. run again!");
                x12++;
            } while (x12 <= max);
            Console.WriteLine("=================================");
        }
    }
}
