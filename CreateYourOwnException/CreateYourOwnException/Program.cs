using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourOwnException
{
    //how to create your own exception and throw your own message
    //when something you are looking for isn't happening as you're expecting
    class Program
    {
        static void CheckEmptyName()
        {
            try
            {
                Person p = new Person(""); //if empty, shows the new exception
            }
            catch (EmptyFiledException ex) //note Exception is the type i choose on Person Class
            {
                Console.WriteLine(ex.Message); //show my own message on EmptyFiledException
                Console.WriteLine(ex.Source); //show my own message on EmptyFiledException
            }
        }
        static void CheckNonEmptyName()
        {
            try
            {
                Person p2 = new Person("Salah"); //if empty, shows the new exception
                p2.PrintName();
            }
            catch (EmptyFiledException ex) //note EmptyFiledException is the exception i created
            {
                Console.WriteLine(ex.Message); //show my own message on EmptyFiledException
                Console.WriteLine(ex.Source); //show my own message on EmptyFiledException
            }
            catch (MissingMemberException ex) //in case i have multiple filed and i missed one
            {
                Console.WriteLine(ex.Message); //show my own message on EmptyFiledException
            }
        }
        static void Main(string[] args)
        {

            CheckEmptyName();
            CheckNonEmptyName();
            Console.ReadKey();
        }
    }
}
/*
Error-1: Can't Leave Field Empty! Must Enter String Data.
Error-2: Exception Source Name: -> CreateYourOwnException
You passed a Salah
You have enter your name => Salah

 */
