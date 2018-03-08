using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnonymousClass
{
    //how to create anonymous/unknow/unnamed class type: مجهول
    /*
     #1: var
     #2: dynamic
         
     */
    class Employee
    {
        public string SayHi()
        {
            return "Welcome to employe class!";
        }
    }
    class Program
    {
        enum Floors
        {
            first, second, third
        }
        static string PrintLine() { return "=============================="; }
        static void MyEmployee(Employee emp) { Console.WriteLine(emp.SayHi()); } //WOOOOOOOW - 
        static void Main(string[] args)
        {
            /*
            #1: var 
            Note: var x = 15; x = "s";//errrrrrror. To override it, must use same type int => x= 35, x=75
            var d; //wrooooooong, must assign a value => var d = "hi"
            */
            var v = "Hello"; // like js
            var x = 15;
            var y = 15.55; y = 35;

            /*
             #2: Dynmaic: must be careful using it
             dynamic d; //works fine
             note i can override normal:
             d = 15; //accepts int => type is dynamic
             d = "sa"; //accepts string => type is dynamic
             d. => won't show any property, but you add it.
             whether you add a property, it will work normal. if exists it is fine
             but if it doesn't it will show error on run time only.
            */
            dynamic d;
            d = 15; //accepts int => type is dynamic
            d = "sa"; //accepts string => type is dynamic 
            Console.WriteLine("My Dynamic variable is => {0}", d); // sa: last stored item
            d = Floors.first; //store enum here
            Console.WriteLine("My Dynamic variable is => {0}", d); // first: get Floors first value

            Console.WriteLine("============================");
            //now let's create anonymous var class: means create an anonymous class that isn't there

            Console.WriteLine("====== Start Var Anonymous Class =======");
            //anonymous class: add readyonly property, add string, doble, [methods not type void -> int, string,..],enum, ...
            var anonClass = new {v1 =11, v2 = 22, v3=33, v4 ="Salah",
                                            v5 = 15.65, v6 = Floors.first,
                                                    v7 = PrintLine(), v8 = true,
                                                        printNewLine = PrintLine()}; 
            //anonClass.v1 = 15; //can't change its value -> it is readonly "property"
            Console.WriteLine(anonClass.v5); //readonly double- 15.65
            Console.WriteLine(anonClass.v7); //readonly method- ===============
            Console.WriteLine(anonClass.v8); //readonly boolean- true
            Console.WriteLine(anonClass.v7); //readonly method - ===============
            Console.WriteLine(anonClass.v1); //readonly int - 11
            Console.WriteLine(anonClass.printNewLine); //readonly method - ===============
            Console.WriteLine(anonClass.v4); //readonly string- salah
            //notice: it does create a readonly property when you pass any value inside that class


            //create a dynamic class anonymous: I am creating anonymous object
            dynamic dynamicClass = new
            {
                v1 = 11,
                v2 = 22,
                v3 = 33,
                v4 = "Salah",
                v5 = 15.65,
                v6 = Floors.first,
                v7 = PrintLine(),
                v8 = true,
                printNewLine = PrintLine(),
                callEmployeeClass = new Employee(), //i can also create an object of this class here.
            };
            Console.WriteLine("====== Start Dynamic Anonymous Class =======");
            //dynamicClass.v1 = 15; //can't change its value -> it is readonly
            //dynamicClass.v5 = "salah"; //if you do, it will show error on run time, not during writing the code
            Console.WriteLine(dynamicClass.v7); //readonly method- ===============
            Console.WriteLine(dynamicClass.v5); //readonly double- 15.65
            Console.WriteLine(dynamicClass.v7); //readonly method- ===============
            Console.WriteLine(dynamicClass.v8); //readonly boolean- true
            Console.WriteLine(dynamicClass.v7); //readonly method - ===============
            Console.WriteLine(dynamicClass.v1); //readonly int - 11
            Console.WriteLine(dynamicClass.printNewLine); //readonly method - ===============
            Console.WriteLine(dynamicClass.v4); //readonly string- salah
            Console.WriteLine(dynamicClass.printNewLine); //readonly method - ===============
            Console.WriteLine(dynamicClass.callEmployeeClass.SayHi()); //readonly call method called SayHi in class employee
            Console.WriteLine(dynamicClass.printNewLine); //readonly method - ===============


            //create anonymous class of Employee class without defining the object type
            new Employee().SayHi(); //retruns the value of it - welcome message

            //create anonymous method: 
            MyEmployee(new Employee());//pass an object to be created - anonymous object
            Console.ReadKey();
        }
    }
}
