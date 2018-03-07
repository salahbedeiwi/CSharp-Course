using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toUpperOrLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // change words to upper/lower case
            string firstName = "salah";
            string lastName = "BEDEIWI";
            Console.WriteLine("Last name: => {0}", lastName.ToLowerInvariant());//bedeiwi
            Console.WriteLine("Last name: => {0}", lastName.ToLower());//bedeiwi
            Console.WriteLine("First name: => {0}", firstName.ToUpper());//SALAH
            Console.WriteLine("============");
            string middleName = "imad";
            char[] c = middleName.ToCharArray();
            string mName = "";
            for (int x=0; x<4; x++)
            {
                //only capitalize the 2nd and last letter
                if(x == 1 || x == 3)
                    mName += c[x].ToString().ToUpper();
                else
                    mName += c[x];
            }
            Console.WriteLine("Middle name: => {0}", mName);//
            string mName2 = "";
            for (int x = 0; x < 4; x++)
            {
                //only capitalize the 2nd and last letter
                if (x == 0)
                    mName2 += c[x].ToString().ToUpper();
                else
                    mName2 += c[x];
            }
            Console.WriteLine("Middle name as first letter Capital: => {0}", mName2);//
            Console.WriteLine("============");

        }
    }
}
