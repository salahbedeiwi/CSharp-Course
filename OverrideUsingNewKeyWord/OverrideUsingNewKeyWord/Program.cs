using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideUsingNewKeyWord
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //can i override constructor? nooooooooooooooo
        public Person()
        {
            Console.WriteLine("You have initilized/inherited new Person class");
        }
        //can i override PrintType()? yessssssssssssssssssssss
        public void PrintType()
        {
            Console.WriteLine("This is Main Person Class");
        }
        public virtual void PrintClassName()
        {
            Console.WriteLine("This is Person Cla ss");
        }
        public virtual void PrintId()
        {
            Console.WriteLine("You have called PrintId() from Person Class");
        }

    }
    class Engineer : Person
    {
        //override virtual method
        public override void PrintId()
        {
            Console.WriteLine("You have called PrintId() from Engineer Class");
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Engineering Courses");
        }
    }
    class Manager : Person
    {
        public new void PrintId()
        {
            Console.WriteLine("You have called PrintId() from Manager Class");
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Management Courses");
        }
    }
    class Doctor : Employee
    {
        //inherit from Employee & Person
        //use override keyword => note, on Employee Class, i used virtual
        //override method from Employee
        public override void Print()
        {
            Console.WriteLine("This is Main Doctor Class");
        }
        //override method from Person
        public override void PrintClassName()
        {
            Console.WriteLine("This is Main Doctor class override");
        }
        public new void PrintType()
        {
            Console.WriteLine("This is Main Doctor Class - use new from new method");
        }
        //override the constructor method from Person class? No you can't
        //
        public Doctor()
        {
            Console.WriteLine("Hi, you have initiated Doctor Class");
        }
    }

    class Employee : Person
    {
        //to override any method that was inherited
        //must return same type exaclty, same name as well
        //note, i added a new keyword 
        //new means => i want to make something new inside that method.
        public new void PrintType()
        {
            Console.WriteLine("This is Main Employee Class");
        }
        //new keyword is used to rewrite the same method, but have
        //different body content like example here.

        //add a new method that can be inherited:
        public virtual void Print()
        {
            Console.WriteLine("This is to be changed when you use override keyword");
        }
        public Employee()
        {
            Console.WriteLine("Default constructor of Employee Class");
        }
    }
    //notes:
    /*
     * when using new keywords, no need to initialize any data type on 
     * the main method or use virtual
     * when using override keyword, parent class method must be virtual 
    */
    class Program
    {
        static void nl()
        {
            Console.WriteLine("===============================");
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.PrintType();
            nl();
            Employee e1 = new Employee();
            //now i want e1.PrintType() not to have the default of p1.PrintType()
            e1.PrintType();
            nl();
            Doctor d1 = new Doctor();
            d1.PrintType();
            d1.PrintClassName();
            d1.Print();
            nl();
            //can i create an object and make it equal to another object
            /*
             * Employee e1 = new Person();
             * Person is the grandparent of Doctor and parent of Employee
            */
            Person p2 = new Employee();//Person can create an object of Employee
            p2.PrintType();
            nl();
            Person p3 = new Doctor();//7afidooooo
            p3.PrintType();
            nl();
            Employee emp2 = new Doctor();
            emp2.PrintType();
            nl();
            //everything in c# inherited from parent class 
            object a = "Salah";
            object b = 150;
            object c = true;
            object d = new object();
            
            object e = 'a';
            
            object f = new Person(); //woooooooooooooooooooooow
            Console.WriteLine(f.GetType());  //get the type of f;
            //diff between new & override
            nl();
            Person p4 = new Engineer();//used override keyword to override some method in Person.PrintId()
            Person p5 = new Manager(); //used new keyword to override some method in Person.PrintId()
            nl(); 
            // which one is stronger new or override
            p4.PrintId();  //override -Engineer Class or Person Class => Engineer Class stronger
            p5.PrintId(); // new - Manager class or Person class => Person Class
            p4.

            nl();


            Console.ReadKey();

        }
    }
}
