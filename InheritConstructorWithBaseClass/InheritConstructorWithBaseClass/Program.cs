using System;

/*
    How to change the inherited constructor from the base class
    Can I call the constructor from the base class in the inherited class


    When i create an instance of inherited class, can i use the costructor and pass param?

    - No, it will not work
     
 */
namespace InheritConstructorWithBaseClass
{
    //base class(parent)
    class Person
    {
        private string name;
        public string N
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //create base constructor: default
        public Person()
        {
            Console.WriteLine("You are using Person Class");
        }
        //pass one param
        public Person(string type = "person")
        {
            type.Trim(); //clear spaces
            Console.WriteLine("=> Your type is {0}", type);
        }
    }
    class Employee: Person {


        //Can i call the Person constructor: No, you can't
        /* 
            public Person()
            {
                Console.WriteLine("You are using Employee Class");
            }
        */
        /*
            Can I use the following to call inherited constructor? 
        */
        //inherit default parameter: don't pass any arguments on base()
        //public Employee() : base(){

        //}
        //inherit constructors from base(parent). with the string
        //when i crate an instance of Employee and pass no parameters: Employee e = new Employee();
        public Employee() : base("Employee")
        {

        }
        //can i have a constructor that takes an arguments
        //when i crate an instance of Employee and pass string parameters: Employee e = new Employee("Doctor");
        public Employee(string n) : base(n)
        {
            //here i am telling my Employee Constructor to behave like base(n)=>parent class with param;
        }
        //can i generate more than one Employee() constructor with base class base()? No
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.N = "Salah";
            Console.WriteLine("===============================================");
            Person p2 = new Person(p1.N);
            Console.WriteLine("===============================================");
            Person e2 = new Employee(); //common methods & atttributes inherited from Person in Employee
            Console.WriteLine("===============================================");
            //note below will use the inherited constructor results
            Employee e1 = new Employee();
            Console.WriteLine("===============================================");
            Employee e3 = new Employee("Sayed");
            Console.WriteLine("===============================================");
            Console.ReadKey();
            /*  Results: 
                 You are using Person Class
                ===============================================
                => Your type is Salah
                ===============================================
                => Your type is Employee
                ===============================================
                => Your type is Employee
                ===============================================
                => Your type is Sayed
                ===============================================
             */
        }
    }
}
