using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCheckIntNum
{
    class Program
    {
        static void CheckMaxInt()
        {
            try
            {
                checked
                {
                    int i = 1;
                    int i2 = checked(2147483647 + i);
                    Console.WriteLine(i2);
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Something went wrong with the max size of check! "
                                + ex.Message);
            }
        }
        static void Main(string[] args)
        {

            //usually if you suspect any code, use checked
            //checked: shows error if something shows up
            //unchecked: hide the error on run time
            CheckMaxInt();
            Console.ReadKey();
        }
    }
}
