using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExolicitOperator
{
    class Person {
        //get the type of Employee and return the type of employee
        //when assigning Employee type to person object
        public static explicit operator Employee(Person p)
        {
            return new Employee();
        }
    }
    class Employee {
        public static explicit operator Person(Employee p)
        {
            return new Person();
        }
    }
    class MyInt
    {
        //ley MyInt accepts (MyDouble) as a casting
        //pass MyInt d as a parameter
        public static explicit operator MyDouble(MyInt d)
        {
            //return the value stored by the object
            return new MyDouble();
        }
    }
    class MyDouble
    {
        public static explicit operator MyInt(MyDouble d)
        {
            //return the value stored by the object
            return new MyInt();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //explicit: casting means to make things the same type
            Person p = new Person();
            Employee e = new Employee();

            p = (Person)e; //p is the object type, Person must be same object type
            Console.WriteLine(p);//ExolicitOperator.Person
            //ex: int x = (int)y;
            e = (Employee)p; //must use casting
            Console.WriteLine(e);//ExolicitOperator.Employee


            MyInt i = new MyInt();
            MyDouble D = new MyDouble();

            i = (MyInt)D;
            Console.WriteLine(i);//ExolicitOperator.MyInt
            D = (MyDouble)i;
            Console.WriteLine(D);//ExolicitOperator.MyDouble

            int x = 15;
            double y = 15.65;

            int f = (int)y; //let y be the same type as f - int
            Console.WriteLine(f);//15
            Console.WriteLine(f.GetType());//System.Int32
            double h = (double)x;//let x to be the same type as double
            Console.WriteLine(h);//15
            Console.WriteLine(h.GetType());//System.Double
            Console.ReadKey();
        }
    }
}
/*
ExolicitOperator.Person
ExolicitOperator.Employee
ExolicitOperator.MyInt
ExolicitOperator.MyDouble
15
System.Int32
15
System.Double
*/
