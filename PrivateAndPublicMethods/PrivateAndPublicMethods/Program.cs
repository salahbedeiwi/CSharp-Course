using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAndPublicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CapitalizMyName.ReturnName("    salah        bedeiwi    "));

            Console.ReadKey();
        }
    }
    public static class CapitalizMyName
    {
        /*
            A non-static class can contain static methods, 
            fields, properties, or events

            no set or get variables to be defined
            you can't declare/initiate any fields/attributes
            you apply methods that will do a specific job for you
            all methods must be static inside a static class
            **Can't have any instance constructors
             public CapitalizMyName()
                {
                    //this is wrong, because we can't create an 
                    instance of static class
                }
            non static class can have an instance constructors
        */
        public static string ReturnName(string name) {
            //trim both sides and spaces
            return name.Trim().ToUpper(); //convert it to upper case
         }
        /*
            public CapitalizMyName()
            {
                Console.Write("
                        I can't decalare an instance constructors of class
                ");
            }
        */
        //can i have private methods on static class? yes
        //can i access private methods outside this class? no, it's private
        static int PrintId(int id)
        {
            return id;
        }
        //can i declare a private and non static method on static class? no
        /*
            int PrintHouseNumber(int houseNumber)
            {
                 return houseNumber;
            }
        */
    }
    
}
