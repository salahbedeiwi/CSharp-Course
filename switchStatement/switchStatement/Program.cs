using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            //another example
            Console.Write("Enter num 1: => ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            //switch statement.
            switch (num1)
            {
                //in case of num1 == 5
                case 5 :
                    Console.WriteLine("You are 5");
                    break;
                
                case 6:
                    Console.WriteLine("You are 6");
                    break;

                case 8:
                    Console.WriteLine("You are 8");
                    break;

                default:
                    Console.WriteLine("none");
                    break;
            }
            Console.WriteLine("-----------------------------------");

            //another example
            Console.WriteLine("Choose a letter: c, b or d");
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case 'c':
                    Console.WriteLine("You choose 'c' => Carrot!");
                    break;
                case 'b':
                    Console.WriteLine("You choose 'b' => Banana!");
                    break;
                case 'd':
                    Console.WriteLine("You choose 'd' => Desserts!");
                    break;
                default:
                    Console.WriteLine("You choose something that doesn't exists");
                    break;
            }
            Console.WriteLine("-----------------------------------");
            //another example

            Console.Write("Enter Name of Number: Zero, One or Two => ");
            string strName = Console.ReadLine();
            switch (strName)
            {
                case "Zero": //capital letter
                case "zero": //small letter
                    Console.WriteLine("You choose 'Zero' => Big Event!");
                    break;
                case "One":
                case "one":
                    Console.WriteLine("You choose 'One' => One Laptop!");
                    break;
                case "Two":
                case "two":
                    Console.WriteLine("You choose 'Two' => Win an Ipod!");
                    break;
                default:
                    Console.WriteLine("You choose something that doesn't exists");
                    break;
            }
            Console.WriteLine("-----------------------------------");
            //another example

            Console.WriteLine("Choose product number: 1,2,3,5,4,8,6,15");
            int prodNum = Convert.ToInt32(Console.ReadLine());
            switch (prodNum)
            {
                //note, 1 & 15 has the same product number
                case 1:
                case 15:
                    Console.WriteLine("Your product #{0} price is $5,500.50", prodNum);
                    break;
                case 2:
                    Console.WriteLine("Your product #{0} price is $1,500.50", prodNum);
                    break;
                case 3:
                    Console.WriteLine("Your product #{0} price is $500.50", prodNum);
                    break;
                case 5:
                    Console.WriteLine("Your product #{0} price is $3,765.50", prodNum);
                    break;
                case 4:
                    Console.WriteLine("Your product #{0} price is $1,657.50", prodNum);
                    break;
                case 8:
                    Console.WriteLine("Your product #{0} price is $800.50", prodNum);
                    break;
                case 6:
                    Console.WriteLine("Your product #{0} price is $950.49", prodNum);
                    break;
                default:
                    Console.WriteLine("You choose product #{0} that doesn't exists", prodNum);
                    break;
            }
            Console.WriteLine("-----------------------------------");

            //another example

            Console.WriteLine("Choose product number: 1,2,3");
            Console.WriteLine("Or Enter product name: apple, banna, carrot");
            string prodRes = Console.ReadLine();
            switch (prodRes)
            {
                //note, users may enter product name, or product number
                //need to display the price for it
                case "1":
                case "apple":
                    Console.WriteLine("Your product #{0} price is $5,500.50", prodRes);
                    break;
                case "2":
                case "banna":
                    Console.WriteLine("Your product #{0} price is $1,500.50", prodRes);
                    break;
                case "3":
                case "carrot":
                    Console.WriteLine("Your product #{0} price is $500.50", prodRes);
                    break;
                default:
                    Console.WriteLine("You choose product #{0} that doesn't exists", prodRes);
                    break;
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}
