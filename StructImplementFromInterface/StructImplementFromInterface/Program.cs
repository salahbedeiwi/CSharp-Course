using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructImplementFromInterface
{
    //create an interface
    interface Person
    {
        //create properties - must be used when implemented
        int age { set; get; }
        string name { set; get; }
        //create methods - must be used when implemented
        void AddPerson();
        void RemovePerson();

    }
    //create a struct
    struct Employee: Person //implement interface Person on struct Employee
    {
        /*******struc info that must be declared since i implemented from interface*******/
        private int _EmpAge; //create to assign/set the value from interface of age
        private string _EmpName;//create to assign/set the value from interface of name
        //use all implemented interface Person (properties/methods)
        //interface Person properties
        string Person.name //note that's private - can't be public/private/protected- interface roles
        {
            get {return _EmpName; } set {_EmpName = value; }
        }
        int Person.age//note that's private - can't be public/private/protected - interface roles
        {
            get { return _EmpAge; }
            set { _EmpAge = value; }
        }
        //interface Person methods - can't use public/private/protected - interface roles
        void Person.AddPerson() { Console.WriteLine("Person {0} that is #{1} years, has been Added", _EmpName, _EmpAge); }
        void Person.RemovePerson() { Console.WriteLine("Person {0} that is #{1} years, has been removed", _EmpName, _EmpAge);}
        /*******struc info*******/
        //here add struc attribute:
        private int _empId;
        private string _empAddress;
        private string _empJobTitle;

        //here assign the properties accessiability for the struc attribute(s):
        public int EmpId {
                get { return this._empId; }
                set { this._empId = value; }
        }
        public string EmpAddress { get { return this._empAddress; } set { this._empAddress = value; } }
        public string EmpJobTitle { get { return this._empJobTitle; } set { this._empJobTitle = value; } }
        //here build some constructors methods:
        public Employee(int emp_id) //note can't assign any value here - any constructor methods on struct
        {
            //assign all attributes/properties:
            this._empId = emp_id;
            this._empJobTitle = "";
            this._empAddress = "";
            this._EmpAge = 0;
            this._EmpName = "";
            //tell this constructor to do something:
            Console.WriteLine("Employee Id is: {0:00000}", emp_id);
        }
        public Employee(int emp_id, string emp_address, string emp_job)
        {
            //assign all attributes/properties:
            this._empId = emp_id;
            this._empJobTitle = emp_job;
            this._empAddress = emp_address;
            this._EmpAge = 0; //won't use but must be assigned
            this._EmpName ="";//won't use but must be assigned
            //tell this constructor to do something:
            string result = "";
            result += string.Format("=>Id is: {0:00000}\n", emp_id);
            result += string.Format("=>Address is: {0}\n", emp_address);
            result += string.Format("=>Job Title is: {0}\n", emp_job);
            Console.WriteLine(result);
        }
        //here build struc methods:
        public void printAll()
        {

            Console.WriteLine("You have called PrintAll Method:");
            string result = "";
            //these _empId, .... must be assigned, else default value will show
            result += string.Format("=>Id is: {0:00000}\n", _empId); //format it like 00001
            result += string.Format("=>Address is: {0}\n", _empAddress);
            result += string.Format("=>Job Title is: {0}\n", _empJobTitle);
            Console.WriteLine(result);
        }
    }
    //main program class
    class Program
    {
        //add cool line with a messgae: capialize all
        static void AddCoolLine(string addMyLine)
        {
            Console.WriteLine("\n============= {0} =============\n", addMyLine.ToUpper());
        }
        //get/access all common members of interface by ("interface Person") that "Employee struct" implemented
        static void UseInterfaceWithStruct()
        {
            AddCoolLine("Access all Properties/Methods of Interface in Struc");
            Person em1 = new Employee(); //interface -> Employee common members from Person
            //note i only have the access to data in Person, why? because the obj. Person() -> Employee()
            //create an object of interface Person and assign it to the object name Employee()
            // so that Employee() can access all data in interface Person
            //use all properties/methods of the interface
            em1.age = 30;
            em1.name = "Salah";
            em1.AddPerson();
            em1.RemovePerson();
        }
        //get all members of struct not the implemented from the interface:
        static void UseStructMembers()
        {
            AddCoolLine("Access all Attributes/Properties/Methods/Constructor of Struc");
            Employee em1 = new Employee(); //main official constructor
            //note i only have the access to struct Employee, why? because the obj. Employee() -> Employee()
            //create an object of struct Employee and assign it to the object name Employee()
            // so that Employee() can access all data in Employee()
            //now assign value to the struc : note i only have access by em1. -> id, address and job
            em1.EmpJobTitle = "Software Engineer";
            em1.EmpId = 1;
            em1.EmpAddress = "Minnesota, Usa";
            AddCoolLine("now print all param on a method inside Employee struct");
            //now print all param on a method inside Employee
            em1.printAll();
            //now call first constructor with one arg passed:
            AddCoolLine("now call first constructor with one arg passed inside Employee struct");
            Employee em2 = new Employee(em1.EmpId);
            //now call first constructor with 3 arg passed:
            AddCoolLine("now call first constructor with 3 argw passed inside Employee struct");
            Employee em3 = new Employee(em1.EmpId,em1.EmpAddress, em1.EmpJobTitle);
        }
        //main method:
        static void Main(string[] args)
        {
            UseInterfaceWithStruct(); //call UseInterfaceWithStruct() method
            UseStructMembers(); // call UseStructMembers() method
            Console.ReadKey();//keep console on till i hit a key
        }
    }
}
/*
    =======Interfaces===================
    can't define fields/attributes
    methods don't have any body content
    can't include public/private/protected at all
    can't create/declare a variable of it
    can't create an object of it

    create property: getter & setter - must not return anything
    create method: must use everything here - must be empty
    can have more than one interface inside namespace

*/
