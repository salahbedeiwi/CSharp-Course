using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnonymousMethod
{
    class Program
    {
        //crate anonymoud method:
        /*Syntax: delegate void anonymoudMethod(optional to pass param.); */
        delegate void anonymoudMethod(); //can print anything
        delegate int returnIntNow(); //must use but return int
        delegate void PrintSomething(object x); //pass anything
        static void Main(string[] args)
        {
            //how to call anonymous method:
            //imagine that you are declaring a variable as method ????????imagine??????
            //syntax: anonymoudMethod m1 = delegate { }; 
            anonymoudMethod m1 = delegate { }; // as type looooooooooooooool
            m1(); //-> method name now called m1,
            anonymoudMethod m2 = delegate { string name = "Salah"; Console.WriteLine(name); }; //Create string
            m2(); //-> method name called m2()
            anonymoudMethod m3 = delegate { Console.WriteLine("Anonymous Method - 3");  }; //add things
            m3(); //-> method name called m3()
            anonymoudMethod m4 = delegate {
                //here is method, returns void - do whatever with it
                Console.WriteLine("Welcome to anonymous method#4");
            };
            m4();
            Console.WriteLine("====================================");

            //now call another anonymous method that has a return type int:
            returnIntNow rInt_1 = delegate { return 1; }; //must return something - return int type
            Console.WriteLine(rInt_1()); //1
            Console.WriteLine("====================================");

            returnIntNow rInt_2 = delegate { int x = 15, y = 16, res = x * y;  return res; }; //must return int type
            Console.WriteLine(rInt_2()); //15*16=240
            Console.WriteLine("====================================");

            //use PrintSomething(object x)
            PrintSomething Ps = delegate(object x) { Console.WriteLine("Object passed => {0}", x); };
            Ps("salah");
            Ps("Imad");
            Ps("Bedeiwi");
            Ps(153.65);
            Ps(18);
            Console.WriteLine("====================================");
            PrintSomething getNumTimes = delegate (object x) {
                int square = (int)x * (int)x;  Console.WriteLine("Square of {0} is {1}", x , square);
            };
            getNumTimes(15); //125
            Console.WriteLine("====================================");
            //get square of all values in array
            int[] arr1 = new int[] { 15, 18, 19, 20, 21, 22, 23, 36 };
            foreach(int a in arr1)
            {
                getNumTimes(a);
            }
            Console.ReadKey();
        }
    }
}
