using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeNameSpace; //Called from Employee.cs
namespace CreateClass
{
    class Program
    {
        static void getEmployee()
        {
            // create an instance of Employee Class and then call it
            //i can call any public method static or non static
            Employee firstEmp = new Employee();
            firstEmp.id = 15;
            firstEmp.name = "Salah Bedeiwi";
            firstEmp.phone = "612-644-1634";
            firstEmp.address = "361 81st Ave NE, Spring Lake Park Mn";
            firstEmp.salary = 80000.076;
            firstEmp.printEmployeeData();
        }
        static void getEmployeeTwoAdvanced()
        {
            // create an instance of Employee Class and then call it
            //i can call any public method static or non static
            Employee firstEmp = new Employee();
            //think of this array as a database
            object[] emp = new object[] { 15, "Salah Bedeiwi", "612-644-1634",
                            "361 81st Ave NE, Spring Lake Park Mn", 80000.059 };
            firstEmp.id = Convert.ToInt32(emp[0]);
            firstEmp.name = (string)emp[1];
            firstEmp.phone = (string)emp[2];
            firstEmp.address = (string)emp[3];
            firstEmp.salary = (double)emp[4];
            firstEmp.printEmployeeData();
        }
        static void Main(string[] args)
        {
            getEmployee(); //make it simple and call a method above
            getEmployeeTwoAdvanced(); //advance employee using array
            // or i can call it like this static method only when not
            //creating a class:
            Employee.printEmployeeTerms();
            Console.ReadKey();
        }
    }
}
