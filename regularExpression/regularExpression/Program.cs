using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //import Regular Expressions
namespace regularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            // Regular Expression
            /*
             => #1 using System.Text.RegularExpressions; //import Regular Expressions
             * \d => any number between 0-9
             * \w => any small/capital or any number 0-9
             * \s => space
             * [] => use it for altanseeq (formatting) 
             *              => [a-z] => need letters from a-z small
             *              => [A-Z] => need letters from a-z capital
             *              => [0-9] => need numbers between 0-9
             *              => [5-8] => need numbers between 5-8
             * {} => used for cells
             *              => \d\d\d => means 3 cells/digits/numbers
             *              \d{5} => means i need \d\d\d\d\d
             *              \d{2} => means i need \d\d
             *              \w{2} => \w\w => 2 letters, 2 digits
             *              [a-z]{2, 16} => min letters is 2 and max letters is 16
             *               
             * * => digits             
             *              => \w* : you could format \w as much you like,
             *                      or you don't have to enter any digits
             * + => digits 
             *              => \d+ => you can have as many as digits, but at least
             *                              you must enter one digit
             * ? => used for digits
             *              => \d? 
             *                  => you can skip this format - optional
             *                  => you can only enter one digits
             *                  => you can't enter more than one digit or none 
             * () => add formating together, (expression) 
             *              => use or format and compare other expressions 
             *                  to validate specific elements/ emails/phones/..
             *                 => (\d[A-Za-z\d])
             *                          => start with number
             *                          => end with number
             *                          => one letter in the middle
             *                          
             *                 => (\d[A-Za-z\d])?
             *                      => whether you enter it once,
             *                      => or it is optional to skip
             *                      => 5a4 => only once or not at all
             *                 => (\d[A-Za-z\d])+
             *                      => whether you enter it at least one time,
             *                      => or as many as you like
             *                      => 5a46e75u67f9 => entered many times
             * | => or
             *          => (expression) | (expression_1) | (expression_2)              
             *           (\d[A-Za-z\d])+ | (\d[A-Za-z\d])? | (\d[A-Za-z\d])*   
             * \+ => user must enter +
             * \- => user must enter -
             * \* => user must enter *
             * \? => user must enter ?
             * \. => user must enter .
             * \@ => user must enter @            
             * \d...\d
             *          => user enter a digit at the beginning and the end
             *          => user also can ignore the middle digits
             * \d.+\d      
             *          => user enter a digit at the beginning and the end
             *          => user also need to enter at least one digit in between
             *       
             *       
             *              
            */
            Console.WriteLine("==============================");
            //validate phone: Regex
            // Regex => data type like string, int, ... so we must use using namespace 
            // create a new instance, so i can use my pattern
            Regex regExp = new Regex("\\d{3}"); // 3 digits
            Console.Write("Enter your number => ");

            string userNumber = Console.ReadLine();
            //first solution
            if (regExp.IsMatch(userNumber) && userNumber.Length < 4) //if true,
            {
                Console.WriteLine("You entered => {0}", userNumber);
            }else
            {
                Console.WriteLine("must enter 3 numbers");
            }
            Console.WriteLine("==============================");
            //second solution => ^\d{3}$ => to not use Length.
            //here, i only need this to accept 3 digits and not more than 3
            Regex regExp_2 = new Regex("^\\d{3}$"); // only 3 digits
            Console.Write("Enter your number => ");

            string userNumber_2 = Console.ReadLine();
            if (regExp_2.IsMatch(userNumber_2)) //if true,
            {
                Console.WriteLine("You entered => {0}", userNumber_2);
            }
            else
            {
                Console.WriteLine("must enter 3 numbers");
            }
            Console.WriteLine("==============================");
            Regex regExp_20 = new Regex("^\\d{3,15}$"); // at least 3 digits up to 15 digits
            Console.Write("Enter your number => ");

            string regExp_212 = Console.ReadLine();
            if (regExp_20.IsMatch(regExp_212)) //if true,
            {
                Console.WriteLine("You entered => {0}", regExp_212);
            }
            else
            {
                Console.WriteLine("must enter 3-15 numbers");
            }
            Console.WriteLine("==============================");
            Regex regExp_2000 = new Regex("^\\d{3}-\\d{3}-\\d{4}$"); // 123-456-6547
            Console.Write("Enter your phone number => ");

            string regExp_21200 = Console.ReadLine();
            if (regExp_2000.IsMatch(regExp_21200)) //if true,
            {
                Console.WriteLine("You entered => {0}", regExp_21200);
            }
            else
            {
                Console.WriteLine("must enter 123-123-1231 numbers");
            }
            Console.WriteLine("==============================");
        }
    }
}
