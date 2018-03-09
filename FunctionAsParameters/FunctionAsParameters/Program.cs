using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAsParameters
{
    class MyRun
    {
        //Func<int> x => Func is delegate,
        //<enter the return type value of that method you passing, but not void>
        // then enter a variable for that method to pass

        public static void PassMethod(Func<int> MyMethod)
        {
            MyMethod();
        }
        public static void PassMethodWithParam( Func<string, double, string> MyMethod ){
            //Func<string, double, int> MyMethod => my method accepts 2 param string and double
            //=> last param is always the return type => if int, string, object, .....
            //that's the param that my method will be returning
            //Console.WriteLine(MyMethod("SALAH", "15.65"));
            MyMethod("SALAH", 15.65);  //Pass the first two paramters i am expecting
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            MyRun.PassMethod(ReturnOne);
            MyRun.PassMethod(ReturnTwo); 
            MyRun.PassMethodWithParam(ReturnThree);
            Console.ReadKey();
            
        }
        static int ReturnOne()
        {
            Console.WriteLine("Welcome, We are returning one");
            return 1;
        }
        static int ReturnTwo()
        {
            Console.WriteLine("Welcome, We are returning two");
            return 2;
        }
        static string ReturnThree(string s, double c)
        {
            Console.WriteLine("You are passing to param!");
            Console.WriteLine("Your s is {0} and your double is {1}", s, c);
            return "Called ReturnThree";
        }
    }
}
