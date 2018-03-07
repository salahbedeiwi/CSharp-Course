using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitString
{
    class Program
    {
        static void Main(string[] args)
        {
            // split a string
            string name, splitString, splitString_1, splitString_2,
                splitString_3, splitString_4;
            name = "welcome to c#";
            //split a string and save it in an array
            //must use single quote, search for space
            //note it take the space off when printing
            string[] splitStr = name.Split(' ');
            foreach (string s in splitStr) {
                Console.WriteLine(s);//will split it to 3 elements
            }
            Console.WriteLine("===============");
            splitString = "1/2/c#";
            string[] splitStr_2 = splitString.Split('/');
            //note it take the / off when printing
            foreach (string s in splitStr_2)
            {
                Console.WriteLine(s);//will split it at /            
            }
            Console.WriteLine("===============");
            splitString_1 = "salah bedeiwi is a software engineer";
            Console.WriteLine("===============");
            Console.WriteLine("string => {0}", splitString_1);
            Console.WriteLine("===============");
            string[] splitStr_3 = splitString_1.Split('e');
            foreach (string s2 in splitStr_3)
            {
            //note it take the letter "e" off when printing
                Console.WriteLine(s2);//will split it at everytime it sees e
            }
            Console.WriteLine("Number of elements in {0} after splitting is {1}",
                                splitString_1, splitStr_3.Length);
            Console.WriteLine("===============");
            Console.ReadKey();
        }
    }
}
