using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // If Statement
            Console.WriteLine("What is your age?");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            if (age >= 12)
            {
              Console.WriteLine("You age is => " + age);
            }
            else
            {
                Console.WriteLine("What is your age? musst be >= 12: ");
                string ageStrRpt = Console.ReadLine();
                int ageR = int.Parse(ageStrRpt);
            }
            Console.WriteLine("Have you graduated from school? y/n");
            string res = Console.ReadLine();
            char res_ans = Char.Parse(res);
            if(res_ans == 'y')
            {
                Console.WriteLine("Congrats, you are eligable to enroll on our course!");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligable to enroll on our course!");
            }
        }
    }
}
