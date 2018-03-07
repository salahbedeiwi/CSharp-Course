using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name? => ");
            string str = Console.ReadLine();
            //how to reverse a string
            string strReverse = "";
            for(int x = str.Length-1; x >= 0; x--)
            {
                strReverse += str[x];
            }

            Console.WriteLine("you entered => {0}", str);
            Console.WriteLine("reverse it => {0}", strReverse);
            Console.WriteLine("================================");
            string funnyMan = "Roscoe Arbuckle";
            string backwardsGuy = new string(funnyMan.Reverse().ToArray());
            Console.WriteLine("you entered => {0}", funnyMan);
            Console.WriteLine("reverse it => {0}", backwardsGuy);
            Console.WriteLine("================================"); 
        }
    }
}
