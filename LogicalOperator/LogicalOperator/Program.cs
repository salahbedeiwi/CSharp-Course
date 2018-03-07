using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // learn logical operators: and &&, or ||  and not ! 
            /* 
             * salah and amr must visit us: both must represent
             * t and t = t
             * t and f = f
             * f and f = f
             * 
             * salah or amr visiting us: one must represent
             * t or f  = t
             * t or t  = t
             * f or f  = f
             * 
             * not salah shows up. anyone but salah(salah is the true logical action)
             * !salah = true, anyone but salah => exactly what i want
             * !true  = false
             * !false = true
             */
            /** Practice **/
            Console.WriteLine("========== Practice Logical Operators =========");
            bool and1 = true && true,
                 and2 = true && false,
                 and3 = false && true,
                 and4 = false && false;
            Console.WriteLine("========== And Operators && =========");
            Console.WriteLine("true && true => " + and1);
            Console.WriteLine("true && false => " + and2);
            Console.WriteLine("false && true => " + and3);
            Console.WriteLine("false && false => " + and4);

            bool or1 = true || true,
                 or2 = true || false,
                 or3 = false || true,
                 or4 = false || false;
            Console.WriteLine("========== Or Operators || =========");
            Console.WriteLine("true || true => " + or1);
            Console.WriteLine("true || false => " + or2);
            Console.WriteLine("false || true => " + or3);
            Console.WriteLine("false || false => " + or4);

            bool notTrue1 = !true; //!ture = false
            Console.WriteLine("========== Not Operators ! =========");
            Console.WriteLine("not true is => " + notTrue1);
            Console.WriteLine("========== Done =========");















        }
    }
}
