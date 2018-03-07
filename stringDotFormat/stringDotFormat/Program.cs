using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringDotFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //string . format => string.Format("{0},{1}")
            string strName = "Salah",
                   strnJob = "Programmer",
                   strPhon = "6126441634",
                   strData = "Name: " + strName +
                                "\nJob: " + strnJob +
                                "\nPhone: " + strPhon;
            Console.WriteLine(strData);
            string strFormatData = string.Format("Name: {0} \nJob: {1} \nPhone: {2}",
                                                strName, strnJob, strPhon);
            Console.WriteLine(strFormatData);
            Console.WriteLine("==============================");
            int invNum = 1;
            /* Format it like this
             * 0001
             * 0002
             * .
             * .
             * .
             * .
             * .
             * 0009
             * 0010
             * 
             * */
            string strInv = string.Format("{0:0000}", invNum);

            Console.WriteLine(strInv);
            Console.WriteLine("==============================");
            //print numbers in a sequence
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string strInvArr;
            foreach (int num in nums)
            {
                strInvArr = string.Format("{0:00000}", num);
                Console.WriteLine("Invoices: {0}", strInvArr);
                Console.WriteLine(string.Format("{0:00}", num));
            }
            Console.WriteLine("==============================");
            //format this as price
            /*
             * int a = 150;
             * int salary = 7000;
             * {0:c} => 150.00 => 2 decimals by default
             * {0:c0} => 150 . no deciamsl
             * {0:c6} => 150.000000   => 6 deciaml digits
             * {0:f}", salary); //7000.000, no $ here - fraction
             * {0:f0}", salary); //7000, no $ here
             * {0:f2}", salary); //7000.00, no $ here
             * ("{0:x}",num12));//1055 => 41f in hexadecimal
             * 
            */
            int price = 150; 
            Console.WriteLine("Your price is {0:c}", price); //$150.00
            Console.WriteLine("==============================");
            //format this as price
            Console.WriteLine("Your price is {0:c0}", price);//$150
            Console.WriteLine("==============================");
            //format this as price
            Console.WriteLine("Your price is {0:c6}", price);//$150.000000
            Console.WriteLine("==============================");
            int salary = 7000;
            string sal = string.Format("{0}", salary);
            Console.WriteLine("Your price is {0:c}", salary); //$7,000.00
            Console.WriteLine("Your price is {0:f}", salary); //7000.000, no $ here
            Console.WriteLine("Your price is {0:f0}", salary); //7000, no $ here
            Console.WriteLine("Your price is {0:f2}", salary); //7000.00, no $ here
            Console.WriteLine("==============================");
            string myDate = string.Format("{0}", "01/01/2000 03:15 pm");
            Console.WriteLine(myDate);//01/01/2000 03:15 pm
            DateTime dt = Convert.ToDateTime("01/01/2000 03:15 pm");
            string myDate2 = string.Format("{0:dd/MM/yyyy}", dt);
            Console.WriteLine(myDate2);//01/01/2000
            Console.WriteLine("==============================");
            int num12 = 1055;
            //print as hex
            Console.WriteLine(string.Format("{0:x}",num12));//41f
            Console.WriteLine("==============================");
            string lName = "Bedeiwi";
            Console.WriteLine("Last name is {0}!", lName);
            Console.WriteLine("==============================");



        }
    }
}
