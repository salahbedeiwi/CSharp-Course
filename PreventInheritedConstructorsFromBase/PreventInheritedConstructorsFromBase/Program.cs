using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreventInheritedConstructorsFromBase
{
    //how to prevent using the inherited constructor on the inherited class from base class
    class Company
    {
        //only use this constructor when creating an obj of Company => : base(t/f, optional n)
        //note n will be optional when recalling this constructor since i give it a default value
        public Company(bool IsRun = true, string n = "company")
        {
            //note i only made this to work if you pass true
            if(IsRun)
            {
                Console.WriteLine("You have called {0} Base Class", n);
                Console.WriteLine("===================================");
            }
        }
    }
    //Company -> Products
    class Products : Company
    {
        //inherit all default info from Company
    }
    //Company -> Employee
    class Employee :Company
    {
        //Use Company() main constructor
        //If you don't pass Employee, it will by default company as defined on company class
        public Employee() : base(true, "Employee") { }
    }
    //Company -> Customer
    class Customer : Company
    {
        //Don't use Company() main constructor,, pass fale using the 
        // base(false, no need because i gave it default value)
        //false means, it will not work at all.
        public Customer() : base(false) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company(); //this will run base class
            Products prod = new Products();//didn't change anything on main class, works fine
            Employee emp  = new Employee();//passed true, it will work
            Customer cust = new Customer();//passed false, won't work
            Console.ReadKey();

        }
    }
    /*               Results
        You have called company Base Class
        ===================================
        You have called company Base Class
        ===================================
        You have called Employee Base Class
        ===================================
    */
}
