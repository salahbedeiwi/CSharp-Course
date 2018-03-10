using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsInInheritance
{
    //IS keyword: Is Str1 variable type of string?
    //As keyword: Can we convert str1 string AS an object?
    class Program
    {
        class Person {
            public virtual void Print() { Console.WriteLine("Person"); }
            public void PrintNow() { Console.WriteLine("Person Class"); }
        }
        class Employee:Person {
            public override void Print() { Console.WriteLine("Override Employee - 1"); }
            public void Print123() { Console.WriteLine("Employee - 123"); }

        }
        static void Main(string[] args)
        {

            Employee e = new Employee();
            Person per = new Person();
            per.Print();//prints what's in person
            per.PrintNow(); //prints what's in Person
            //let p to be exactly as e:
            //#1
            Person p = e;
            p.Print();//employee: override
            p.PrintNow();//person
            //#2
            Person p22 = e as Person;//as keyword
            p22.Print();//employee - override
            //let p22 is the object as it is the Person class
            //#3
            Person p33 = new Employee() as Person;
            p33.Print();//employee

            // do the oppoise: can't convert e -> p : it is not set of instance
            Person p15 = new Person();
            try
            {
                Employee e444 = p15 as Employee;
                e444.PrintNow();
                e444.Print123();
                e444.Print();
            }catch(Exception ex) //show error if you can convert it
            {
                Console.WriteLine("Error: Can't convert e ->  p. " + ex.Message);
            }
            //is keyword:
            object str1 = "Sa";
            if (str1 is string) Console.WriteLine("yes it string");
            //as keyword:
            string x = str1 as string;//can we convert an object to string => str1 as string

            Console.ReadKey();
        }
    }
}
