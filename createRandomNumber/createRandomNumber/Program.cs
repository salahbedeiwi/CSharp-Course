using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate random number
            Random rnd = new Random();
            int rNum = rnd.Next();
            Console.WriteLine(rNum);
            //Next(minVal, maxVal)
            int rNumber = rnd.Next(1, 20); //get random number between 1-19
            Console.WriteLine(rNumber);
            int rMonth = rnd.Next(1, 13); //get random number between 1-12
            DateTime dt = Convert.ToDateTime(rMonth+"/"+rMonth+"/2018");
            Console.WriteLine(dt.ToString("MMMM"));
            Console.WriteLine(dt.ToString("MM"));
            Console.WriteLine(dt.ToString("MMM"));
            Console.WriteLine(dt.ToString("dd-MM tt"));
            Console.WriteLine(dt.ToString("MMMM"));
            Console.WriteLine(dt.ToString("MMMM"));
            Console.WriteLine("==================");
            int rNUMBS = rnd.Next(150);
            Console.WriteLine("0-149 => {0}",rNUMBS);


        }
    }
}
