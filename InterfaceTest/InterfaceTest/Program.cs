using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db1NameSpace;
//note I have added this namespace to include interface Db1NameSpace for Db1
namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================");
            MyDb d = new MyDb();
            //now i need to access attributes, methods, properties on MyDb
            //to use interface, you must used it as to implement any class
            Db2 db2 = new MyDb(); //MyDb is implemented by Db2
            //get all common methods, properties when MyDb is implementing Db2
            db2.Delete();
            Console.WriteLine("=======================================");
            Db1 db1 = new MyDb();
            db1.ConnectionString = "insert into 'xxx' where id = 2";
            db1.Add(); //it uses ConnectionString
            db1.Update();
            Console.WriteLine("=======================================");
            Console.ReadKey();
        }
    }
}
