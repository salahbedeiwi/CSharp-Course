using System;
using System.Collections.Generic;
using System.IO; //stream write text
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_NameSpaceNBase_Names
{
    public class Person
    {
        private int d;
        public string name;
        public string name_2;
        public string name_3;
        //any class that will inherit from me, will have it's own name: 
        //this.GetType().Name
        public Person()
        {
            Console.WriteLine("My Class name is => {0}", this.GetType().Name);
        }
        public Person(bool n = true)
        {
            if(n)
                Console.WriteLine("Main Person Class");
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to main Person method");
        }
    }
    class Financial : Person { }
    class Employee : Person
    {
        //don't inherit from Person same constructor
        public Employee() : base(false) { } 
    }
    class Days
    {
        public Days()
        {
            Console.WriteLine("Main Days Class");
        }
    }
    class Doctor : Employee { }
    class Program
    {
        static void Print(object n)
        {
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            Person p = new Person(); //use default constructor
            Print("=========================================");
            Employee emp = new Employee(); //no default constructor
            Print("=========================================");
            Days d = new Days();//use default constructor
            Print("=========================================");
            //know what is the base class of d
            object d_Type = d.GetType(); //note GetType is an object, 
            //so declare it as object or print it right away
            Print(d_Type); //Class_NameSpaceNBase_Names.Days => namespace.className
            Print(d.GetType()); //Class_NameSpaceNBase_Names.Days => namespace.className
            Print("=========================================");
            //search for method Welcome on person class: 
            //  1. must be public 2.return type and name of method 3. return nothing if no results
            Print(p.GetType().GetMethod("Welcome")); //return type => void Welcome()
            Print(p.GetType().GetMethod("asldfjalsdjfajs")); //no method exits => empty value
            Print("=========================================");

            //get members info => member is my class name or namespace name or base name
            Print(p.GetType().Name); //get name of current member: "Person" => class name
            Print(p.GetType().GUID);//GUID: 2d2b06e4 - 953d - 311a - 8cde - 51e7ca7fc0bc
            Print(p.GetType().IsAbstract);//Is it abstract? true or false => False
            Print(p.GetType().FullName);//Full name but no assembly => Class_NameSpaceNBase_Names.Person
            Print(p.GetType().IsPublic);//is my class public => True, Public class Person {...}
            Print(p.GetType().GetFields());//return all public fields => System.Reflection.FieldInfo[]
            Print(p.GetType().GetFields()[0]);//first field => System.String name (wooooow)
            //print all fields inside p
            object[] fieldsInClass = p.GetType().GetFields();
            foreach(object o in fieldsInClass)
            {
                Print(o);
            }
            //print all properties in p
            object[] methodsInClass = p.GetType().GetMethods();
            foreach (object o in methodsInClass)
            {
                Print(o);
            }
            Print(p.GetType().Namespace);//Namespace => Class_NameSpaceNBase_Names
            Print(p.GetHashCode());//HashCode = > 22008501
            Print(p.ToString()); // Class_NameSpaceNBase_Names.Person
            Print(p.GetType()); //Class_NameSpaceNBase_Names.Person
            Print(p.GetType().IsClass);//is this a class? True
            Print("==============================================================");

            //An array:
            object[] arr1 = new object[] { "Salah", 150, "Bedeiwi"};
            Print(arr1.IsFixedSize); //is my array fixed size: False/True => True
            Print(arr1.Length); // 3
            Print(arr1.Last()); //last element: Bedeiwi
            Print(arr1.GetType());//System.Object[]
            Print(arr1.GetType().IsArray); //is my arr1 an array? True
            Print(arr1.GetType().GetArrayRank());//dimensions in array: 1 => 1-dimension
            Print(arr1.GetType().Name);//object[]
            Print(arr1.GetType().FullName);//System.Object[]
            Print("==============================================================");
            StreamWriter sw = new StreamWriter("test.txt");
            Print(sw.GetType().FullName); //System.IO.StreamWriter
            Print(sw.GetType().Name);//class member name: StreamWriter
            Print(sw.GetType().Namespace);//System.IO
            Print("==============================================================");
            //Say i need to find info that if class is inherting from?
            Employee emp123123 = new Employee(); //no default constructor
            Doctor doctor_1 = new Doctor(); //Doctor:Employee
            Print(doctor_1.GetType().BaseType); // doctor_1 object inherited from: 
                                                // Class_NameSpaceNBase_Names.Employee
            Print(doctor_1.GetType().BaseType.Name);//class name: Employee
            Print(doctor_1.GetType().BaseType.FullName);// Class_NameSpaceNBase_Names.Employee
            //note emp123123 is inherting from Perspm
            Print(emp123123.GetType().BaseType);// Class_NameSpaceNBase_Names.Person
            //note days isn't inherting any info
            Days daysss = new Days();
            Print(daysss.GetType().BaseType);//where it is inherting from? System.Object
            //is Doctor type is the same as arr1 array?
            Print(doctor_1.GetType().IsInstanceOfType(arr1));//FALSE
            //is Doctor type is the same as emp123123 object? 
            Print(doctor_1.GetType().IsInstanceOfType(doctor_1)); //TRUE
            Print("==============================================================");
            //Try something cool. any class that is inheriting from Person, will print default
            //constructors:  this.GetType().Name
            Financial f2 = new Financial();
            Console.ReadKey();




        }
    }
}
/* Results:
My Class name is => Person
=========================================
=========================================
Main Days Class
=========================================
Class_NameSpaceNBase_Names.Days
Class_NameSpaceNBase_Names.Days
=========================================
Void Welcome()

=========================================
Person
2d2b06e4-953d-311a-8cde-51e7ca7fc0bc
False
Class_NameSpaceNBase_Names.Person
True
System.Reflection.FieldInfo[]
System.String name
System.String name
System.String name_2
System.String name_3
Void Welcome()
System.String ToString()
Boolean Equals(System.Object)
Int32 GetHashCode()
System.Type GetType()
Class_NameSpaceNBase_Names
37121646
Class_NameSpaceNBase_Names.Person
Class_NameSpaceNBase_Names.Person
True
==============================================================
True
3
Bedeiwi
System.Object[]
True
1
Object[]
System.Object[]
==============================================================
System.IO.StreamWriter
StreamWriter
System.IO
==============================================================
Class_NameSpaceNBase_Names.Employee
Employee
Class_NameSpaceNBase_Names.Employee
Class_NameSpaceNBase_Names.Person
Main Days Class
System.Object
False
True
==============================================================
My Class name is => Financial

*/
