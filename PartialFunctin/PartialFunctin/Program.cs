using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialFunctin
{
    //partial: mean part of something: 
    //can i name two classes with the same name???
    //say i need to make a class two parts or more
    //you have a class that have 100 methods, 
    //i like 4 developers to work on it
    // create => partial class Employee { }
    //also make sure every class has different methods,
    //means every developer will have a task of things to do
    //but not doing the same thing

    //make this class for attributes
    partial class Employee {
        private int id;
        private long ssn;
        private string name;
    }
    //make this class for properties
    partial class Employee {
        public long SSN { get { return this.ssn; } set { this.ssn = value; } }
        public int ID { get { return this.id; } set { this.id = value; } }
        public string NAME { get { return this.name; } set { this.name = value; } }
    }
    //make this class for Constructors
    partial class Employee {
        public Employee()
        {
            Console.WriteLine("Welcome to Employee Class");
        }

        public Employee(string name)
        {
            this.name = name;
            Console.WriteLine("Welcome {0} to Employee Class", name);
        }
        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
            Console.WriteLine("Welcome {0} to Employee Class. Your id is {1}", name, id);
        }
        public Employee(string name, int id, long ssn)
        {
            this.name = name;
            this.id = id;
            this.ssn = ssn;
            Console.WriteLine("Welcome {0} to Employee Class. Your id is {1} and SSN is {2}"
                                        , name, id, ssn);
        }
    }
    //general private methods:
    partial class Employee {
        private void AddEmployee(string empName)
        {
            this.name = empName;
            Console.WriteLine("You have added a new employee => {0}", empName);
        }
        private void RemoveEmployee(string empName)
        {
            this.name = empName;
            Console.WriteLine("You have removed a new employee => {0}", empName);
        }
    }
    //general print methods:
    partial class Employee {
        public void printAddEmp()
        {
            AddEmployee(this.name);
        }
        public void printRemoveEmp()
        {
            RemoveEmployee(this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.ID = 156;
            e1.NAME = "Salah Bedeiwi";
            e1.SSN = 2553256;
            e1.printAddEmp();
            e1.printRemoveEmp();

            Employee e2 = new Employee(e1.NAME,e1.ID);
            Employee e3 = new Employee(e1.NAME,e1.ID, e1.SSN);
            Console.ReadLine();
        }
    }
}
