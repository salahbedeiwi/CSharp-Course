using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    //learn how to create a generic method - 
    //any type you do, will make it work
    class Program
    {
        //create generic method:
        //accepts no param
        static void myVal<Type2>()
        {
            Console.WriteLine("You have created generic method");
        }
        //accepts 1 param
        static void myVal<Type2>(Type2 t2)
        {
            Type2 myT = t2;
            Console.WriteLine("You have entered type: {0}\nValue: {1}", t2.GetType().Name, t2);
            if(t2.GetType().Name == "Int32")
            {
                //if type is an integer:
                Console.WriteLine("We have dedected that you entered a number: {0}", t2);
            }
            else if (t2.GetType().Name == "String")
            {
                //if type is an String:
                Console.WriteLine("We have dedected that you entered a String: {0}", t2);
            }else
            {
                Console.WriteLine("We have dedected that you entered something but not int or string => but is {0}", t2.GetType().Name);
            }
        }
        //accepts 2 param
        static void myVal<Type3, Type4>(Type3 t3, Type4 t4)
        {
            Type3 myT = t3;
            Console.WriteLine("You have entered\nType: {0} and Value: {1}\nType: {2} and Value: {3}"
                                                            , t3.GetType().Name, t3, t4.GetType().Name, t4);
            if (t3.GetType().Name == "Int32" && t4.GetType().Name == "Int32")
            {
                //if type is an integer:
                Console.WriteLine("We have dedected that you entered a number for both {0} and {1}", t3, t4);
            }
            else if (t3.GetType().Name == "String" && t4.GetType().Name == "String")
            {
                //if type is an String:
                Console.WriteLine("We have dedected that you entered a String for both {0} and {1}", t3, t4);
            }
            else
            {
                Console.WriteLine("We have dedected that you entered something but not int or string => but is {0} and {1}"
                                                                        , t3.GetType().Name, t4.GetType().Name);
            }
        }
        static void Main(string[] args)
        {
            //note you may/may not declare the type when declaring the method below: 
            //myVal(235); or myVal<int>(150);

            //myVal - no param
            myVal<int>();
            Console.WriteLine("============================================");
            //myVal - 1 param
            myVal<int>(150);
            //myVal - 1 param
            myVal(235); 
            //woooooooooooow I didn't declare the type and it does still figure the type by itself
            Console.WriteLine("============================================");
            //myVal - 1 param
            myVal<string>("Salah");
            Console.WriteLine("============================================");
            //myVal - 1 param - an array - string:
            string[] names = new string[] { "ahmed", "ali", "walid" };
            foreach(string x in names)
            {
                myVal<string>(x);
                Console.WriteLine("============================================");

            }
            Console.WriteLine("============================================");
            //myVal - 1 param - an array - object:
            object[] randInfo = new object[] { "random Info",125, 51.25 };
            foreach (object z in randInfo)
            {
                myVal<object>(z);
                Console.WriteLine("============================================");

            }
            //myVal - 2 param - same string
            myVal<string, string>("Salah", "Bedeiwi");
            Console.WriteLine("============================================");
            //myVal - 2 param - same int
            myVal<int, int>(150, 150);
            Console.WriteLine("============================================");
            //myVal - 2 param - different
            myVal<string, int>("Salah", 150);
            Console.WriteLine("============================================");
            Console.ReadKey();

        }
    }
}
