using System;
using CreateClassDDLinClassLibrary;
//call the ddl using CreateClassDDLinClassLibrary; //call the ddl Create......dll 
//- will access all public classes and anything thre
//all you need to do, build you app, then get the .dll file and import it here by
//using the namespace of that dll file
//go to reference inside this project under the properties.
//you will see the CreateClassDDLinClassLibrary there with all classes inside
namespace TestDDLinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //i can access anything inside that file --- wooooooow
            //this is exactly how c# work - saves everything on dll files
            //give it namesspaces, like using system, .... etc
            //you will have an access to everything. light files, ...

            Employee e = new Employee();
            e.address = "361";
            e.phone = "6126441634";
            e.printEmployeeData();
            Console.ReadLine();
        }
    }
}
