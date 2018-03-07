using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db1NameSpace; 
//note I have added this namespace to include interface Db1NameSpace for Db1
namespace InterfaceTest
{
    //implement interface Db1 and Db2,..... I could have more.
    //I can inherit from Class_3, then implement any interface
    // Class MyDb : Db1, Db2, Db3 or
    //class MyDb : Class_3, Db1, Db2, Db3
    class MyDb : Class_3, Db1, Db2, Db3
    {
        //note must use these implemented interface members:
        //rewrite the members of Db1:

        //implement Db1
        //create attributes:
        private string _ConnectionString;
        string Db1.ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }
        void Db1.Add()
        {
            //return the query assigned when creating an object of this
            Console.WriteLine(this._ConnectionString);
        }
        void Db1.Update()
        {
            Console.WriteLine("Update Database!");
        }
        //implement Db2
        void Db2.Delete() { Console.WriteLine("Delete Database!");  }

        //implement Db3, that's created inside Db2.cs
        private string _CreateNewDataBase;
        string Db3.CreateNewDb {
            get { return _CreateNewDataBase; }
            set { _CreateNewDataBase =  value; }
        }
        void Db3.Create() { }
    }
}
