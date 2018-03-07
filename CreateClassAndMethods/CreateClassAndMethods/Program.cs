using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassAndMethods
{
    class Program
    {
        //properties:
        string myName = "Salah";
        static string jbTitle = "Software Engineer";
        //my own method:
        static void MyOwnMethod()
        {
            jbTitle = "Sofrwaaaaaaare Engineer";//i can call static properties
            Console.WriteLine("Welcome to my method, you are a {0}", jbTitle);
        }
        //to call a property: must not be static:
        void MyName()
        {
            // note it is not static, 
            // if it was static method, wont be able to call myName
            myName = "Bedeiwi";
        }
        //main method:
        static void Main(string[] args)
        { 
            //create class and methods:
            //call methods:
            MyOwnMethod();
            // call class from another file: public
            Console.WriteLine(MyFirstClass.SayHello()); 

            //can i call static methods - must be public
            MyFirstClass.MyNewMethodTwo();
            int r = 4 + 3 * 5;
            Console.WriteLine(r);
            string strName = "\tSalah\n";
            for(int z = 1; z <= 5; z++)
            {
                strName += string.Format("=>{0}\n",z);
            }
            Console.WriteLine(strName);
        }
    }
}
