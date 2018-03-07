using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    //how to create your own type => struct
    //like when you create class type, string type, int type,
    //here i want to have struct type => my own
    //can struct inherit from class? no
    //can struct implement from interface? yes
    //struct is used for your structure/create your own building structure
    class Company { }
    abstract class School { }
    interface Shopping { }
    interface Masjid { }
    //if i implement interfaces, i must use what's inside it.
    struct Employee: Shopping, Masjid
    {
        private string _Name; //don't ever initialize a variable (give value ) on strucs
        //private string _Name = "s"; //---wrong
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private int _EmpNo;

        public int EmpNo
        {
            get { return _EmpNo; }
            set { _EmpNo = value; }
        }
        public string _Address;
        public void Print()
        {
            Console.WriteLine("Welcome to your own struct");
        }
        public void PrintAll()
        {
            Console.WriteLine("Welcome {0}, Your address is {1} and Id is {2}",
                                _Name , _Address, _EmpNo);
        }
        //how to create constructor in struc
        //steps: 
        //must use "all" "properties" to be assigned
        //must have parameters passed, can't be empty (parameterless)
        //must have parameters that have been declared to be assigned inside the constructor
        //you can pass any paramters or not.
        public Employee(int id)
        {
            //must assign this 
            this._EmpNo = id;
            _Name = "";
            this._Address = "";
            Console.WriteLine("Your Id is {0}",
                                id);
        }

        public Employee(string name)
        {
            //must assign any property/attribute that was declared 
            this._EmpNo = 0;
            this._Name = name;
            this._Address = "";
            Console.WriteLine("Your Name is {0}",
                                name);
        }
        //you can't assign a default value on parameters:
        //public Employee(string address = "361 81st Ave") //wrooooooooooong
        //can't declare the same one parameters like only passing string only and
        //have constructors multiple times the same
        public Employee(string address, string name, int empId)
        {
            _EmpNo = empId;
            this._Name = name;
            _Address = address;
            Console.WriteLine("Your Address is {0}.\nYour Name is {1}.\nYour Emp Id is {2}.",
                                address, name, empId);
        }
    }
    class Program
    {
        static void CoolLine(string addInfo)
        {
            Console.WriteLine("\n=========={0}=========\n", addInfo);
        }
        static void Main(string[] args)
        {
            //call struct: exactly like class
            CoolLine("Fire Normal Struc - No Param passed");

            //note also on class, when i have a constructor, i must follow the initial one
            //like to pass param if i build a constructor method like that.
            //even we don't have an empty/allowed constructor for struc,
            //we can create an object of it without passing info on there.
            Employee e1 = new Employee();
            //please note one thing here: I could pass parameters or not:
            //cool one feaure here, it doesn't fire anything by default when
            //creating an object of it. Look how declared a constructors with param above
            CoolLine("Fire Method on Struc");
            e1.Print();
            e1.Name = "Salah";
            e1.EmpNo = 150;
            e1._Address = "Minnesota, Usa";
            CoolLine("Fire Method on Struc - after assigned value");
            e1.PrintAll(); //print all info
            //now let's use the constructors:
            CoolLine("Fire New Object on Struc - pass id param");
            Employee e2 = new Employee(e1.EmpNo);//print id only
            CoolLine("Fire New Object on Struc - pass address, name and id params");
            Employee e3 = new Employee(e1._Address,e1.Name, e1.EmpNo); //print all info
            CoolLine("Fire New Object on Struc - pass name param");
            Employee e4 = new Employee(e1.Name);//print name only
            Console.ReadKey();
            
        }
    }
}
/* 
                        Results
==========Fire Normal Struc - No Param passed=========


==========Fire Method on Struc=========

Welcome to your own struct

==========Fire Method on Struc - after assigned value=========

Welcome Salah, Your address is Minnesota, Usa and Id is 150

==========Fire New Object on Struc - pass id param=========

Your Id is 150

==========Fire New Object on Struc - pass address, name and id params=========

Your Address is Minnesota, Usa.
Your Name is Salah.
Your Emp Id is 150.

==========Fire New Object on Struc - pass name param=========

Your Name is Salah
*/
