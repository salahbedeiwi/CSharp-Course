using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //use variable name as identifiers names
            string @string = "salah bedeiwi";
            Console.WriteLine("**************************************");
            Console.WriteLine("Developer Name: " + @string.ToUpper());
            Console.WriteLine("**************************************");
            int x = 5;
            string age = "15";
            double y;
            //convert age to int, double
            int ageInt = Int32.Parse(age); //now converted age to be int data type
            x = Convert.ToInt32(x); //x = 5
            y = Convert.ToDouble(x); // x is int32
            Console.WriteLine("===Convert===");
            Console.WriteLine("Y is => "+ y);
            Console.WriteLine("===Practice===");
            string studentTotal = "15.5";
            double studTot = double.Parse(studentTotal);//converted studentTotal to be double
            Console.WriteLine("Student Total in double => " + studTot);
            string newStudTotal = studTot.ToString(); //convert double to string
            Console.WriteLine("Student Total in string => " + newStudTotal);
            char z = 'z';
            string newZ = z.ToString();
            Console.WriteLine("New Z Char is => " + z);
            //constants
            const int MONTHS = 12;
            Console.WriteLine("Total months in one years is => " + MONTHS + " Months");
            Console.WriteLine("*******************");
            Console.WriteLine("===Cast===");
            int minAge = 77;
            char c = 'c';
            char m = (Char)minAge; //now m = 77 and note it is a char - one single character
            Console.WriteLine("Converted '77' to be one Char displayed as  => "
                                + m); // m => M
            int zNum = 122;
            char zLetter = (Char)zNum;
            Console.WriteLine("Converted '122' to be one Char displayed as  => "
                                + zLetter); // zLetter => z
            //now convert from Char to int
            char rLetter = 'R';
            char equalSign = '=';
            int rInNumber = rLetter; //note it accpeted the conversion easily
            Console.WriteLine("print rLetter from Char to Decimal number => "
                                    + rInNumber); // R = 82 in decimal unicode
            Console.WriteLine("=========================");
            Console.WriteLine("print rLetter as Char => "
                                    + (char)rLetter); //print rLetter as Char
            Console.WriteLine("print rLetter from Char to Decimal number => "
                                    + (int)rLetter); //print rLetter as decimal number
            Console.WriteLine("print equalSign from Char to Decimal number => "
                                    + (int)equalSign); //print equalSign as decimal number
            Console.WriteLine("=========================");
            Console.WriteLine("====Pre Fix & Post Fix ====");
            int one = 1;
            Console.WriteLine("Real one value => " + one); // 1
            one += 1;
            Console.WriteLine("Add one to one variable=> " + one); // 2
            one++; //postfix increment: note it will add one to 2
            Console.WriteLine("added another one => " + one); // 3
            ++one; //prefix increment: note it will add one to 3
            Console.WriteLine("added another one => " + one); //4
            --one; //prefix decrement: note it will subtract one from 4
            Console.WriteLine("subtract another one => " + one); // 3
            one--; //postfix decrement: note it will subtract one from 3
            Console.WriteLine("subtract another one => " + one); // 2
            Console.WriteLine("========== Example =========");
            int f = 5;
            Console.WriteLine("f becomes: => " + f);// 5
            int g = f++;
            Console.WriteLine("g becomes: => " + g);// 5, now new g after it runs is 6
            Console.WriteLine("New f becomes: => " + f);// 6, now f = 6
            Console.WriteLine("New g becomes: => " + g);// 5
            int k = ++f;//add one before executing, 6 + 1 = 7
            Console.WriteLine("New g becomes: => " + k);// 6 => 7
            Console.WriteLine("=========================");
            Console.WriteLine("====Pre Fix & Post Fix ====");
        }
    }
}
