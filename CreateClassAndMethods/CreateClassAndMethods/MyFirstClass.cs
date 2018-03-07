using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassAndMethods
{
    class MyFirstClass
    {
        //my first class:
        public static string SayHello()
        {
            return "Welcome to my first program class";
        }
        //note, this is private method, can't call it outside this class
        //only i can call it on any other method on this page like MyNewMethodTwo()
        static void MyNewMethodOne()
        {
            Console.WriteLine("This is my method one in MyFirstClass");
        }
        //note I can call this from outside this page on the main class
        public static void MyNewMethodTwo()
        {
            MyNewMethodOne();
        }

    }
}
