using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileterNumbersOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInput = 
                    GetUserInput.FilterInputAsInt("asdfAADA^%&%%65a4sd6f5asd65f4");
            Console.WriteLine("Your number is => {0}", myInput);
            Console.ReadKey();
        }
    }
}
