using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void IamAll(Person pAll)
        {
            pAll.Iam();
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            Customer c = new Customer();
            Employee e = new Employee();
            //another smart way of creating a class that has inheritance
            IamAll(p);//Person
            IamAll(c);//Customer
            IamAll(e); //employee

            p.Iam();//Person
            c.Iam();//Customer
            e.Iam();//employee
            Console.ReadKey();
        }
    }
    class Person
    {
        //methods: virtual -> get to use new/override
        public virtual void Iam()
        {
            Console.WriteLine("I am a Person");
        }
    }
    class Customer : Person
    {
        public override void Iam()
        {
            Console.WriteLine("I am a {0}", this.GetType().Name);
        }
    }
    class Employee : Person
    {
        public override void Iam()
        {
            Console.WriteLine("I am an {0}", this.GetType().Name);
        }
    }
}
