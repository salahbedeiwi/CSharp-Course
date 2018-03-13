using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpClasssToDiagrams
{
    public enum Floors { First, Second, Third, Forth }
    public enum FourDirections { East, West, North, South }
    interface Directions
    {
        string goDirections { set; get; }
        void GetDirections();
    }
    class Company : Directions
    {
        //implemented data from Directions:
        private string GoDirection;
        string Directions.goDirections {
            set { GoDirection = value; }
            get { return GoDirection; }
        }
        void Directions.GetDirections() {

            Console.WriteLine("Direction is {0} of the building!", GoDirection);
        }
        //Company info
        private int id;//attribute field
        private string name;//attribute field
        private string address;//attribute field
        private Floors floor; //enum fields
        private double revenue;
        private int rank;
        public string Name { set { this.name = value; } get { return this.name; } }
        public int Id { set { this.id = value; } get { return this.id; } }
        public double Revenue { set { this.revenue = value; } get { return this.revenue; } }
        public int Rank { set { this.rank = value; } get { return this.rank; } }
        public string Address { set { this.address = value; } get { return this.address; } }
        public Floors Floor { set { this.floor = value; } get { return this.floor; } }
        public Company(){ Console.WriteLine("Init Company Class"); } //constructor
        ~Company() { Console.WriteLine("Finished Company Class"); }//destructor
        private void CompanyInfo()
        {
            Console.WriteLine("Name: {0}\nId: {1}\nAddress: {2}\nFloor #: {3}",
                               this.name,this.id, this.address, this.floor );

        }
        public void PrintAll()
        {
            CompanyInfo();
        }
        //delegates
        public delegate void MyCompanySlogan(); //create delegate - anonymous method
        public delegate int MyCompanyRanking(); //create delegate
        public delegate double MyCompanyRevenue(double r); //create delegate - return double

        //events 
        public static event MyCompanySlogan ComingEvent;//craete an event
    }
    class Employee : Company
    {
        private string ssn;
        public string SSN { get { return ssn; } set { ssn = value; } }
        public void EmployeeInfo()
        {
            base.PrintAll();//print everything on company and add new line
            Console.WriteLine("SSN: {0}", ssn);
        }
    }
    class Customer : Company
    {

    }
    public class Orders
    {

    }
    class Program
    {
        public delegate void MyOrders(); //delegate
        public static event MyOrders OrderStatus;//event
        static void Main(string[] args)
        {
            
            //************************//
            Company com = new Company();//company class
            com.Address = "123 2nd st NW";
            com.Floor = Floors.Forth;
            com.Name = "AEP";
            com.Id = 3;
            com.Rank = 7;
            com.Revenue = 877.84;
            com.PrintAll();
            //call delegate - must return int
            Company.MyCompanyRanking comRank = delegate { return com.Rank; }; 
            Console.WriteLine("Company Rank is {0}", com.Rank);
            Company.MyCompanySlogan compSlogan = delegate {
                    Console.WriteLine("Company Slogan: Cool!");
            }; //void
            compSlogan();
            Company.MyCompanyRevenue comRevenue = delegate (double rev) { return rev; };
            Console.WriteLine("Revenue for this company is {0:c2}", comRevenue(com.Revenue));
            Company.MyCompanySlogan companyEvent1 = delegate { Console.WriteLine("Company Event - 1: Party!"); };
            Company.MyCompanySlogan companyEvent2 = delegate { Console.WriteLine("Company Event - 2: Swimming!"); }; 
            Company.MyCompanySlogan companyEvent3 = delegate { Console.WriteLine("Company Event - 3: Prizes!"); };
            companyEvent1();
            companyEvent2();
            companyEvent3();
            //company events: ????????? 
            //i still don't know how to use it inside class that implemetnted from interfaec?

            Directions Icom = new Company(); //company implemented from Directions
            Icom.goDirections = "East";
            Icom.GetDirections();
            //************************//
            Employee emp = new Employee();//Employee class
            emp.SSN = "456456456";
            emp.Address = "123 2nd st NW";
            emp.Floor = Floors.Forth;
            emp.Name = "AEP";
            emp.Id = 3;
            emp.Rank = 7;
            emp.Revenue = 650.87;
            emp.EmployeeInfo();
            Directions Iemp = new Employee();//Employee implemented from Directions
            Iemp.goDirections = "West";
            Iemp.GetDirections();
            Company.MyCompanyRanking empRank = delegate { return emp.Rank; };
            Console.WriteLine("Employee Rank is {0}", empRank());
            Company.MyCompanySlogan empSlogan = delegate { Console.WriteLine("Employee Slogan: Love it"); };
            empSlogan();
            Company.MyCompanyRevenue empRevenue = delegate (double rev) { return rev; };
            Console.WriteLine("Revenue for this Employee is {0:c2}", empRevenue(emp.Revenue));

            //use delegate events frm class orders

            //class diagram - add new item, class diagram, save as CompanyDiagram.cd
            //click on view option, view class view (ctrl + shift + c)

            //use events 

            OrderStatus += delegate { Console.WriteLine("Order #15 is shipped!"); };//events
            OrderStatus += delegate { Console.WriteLine("Order #16 is shipped!"); };//events
            OrderStatus += delegate { Console.WriteLine("Order #52 is not shipped!"); };//events
            OrderStatus();
            //delegates
            MyOrders orders = delegate { Console.WriteLine("Order #15!"); };
            orders();
            Console.ReadKey();
        }
    }
}
