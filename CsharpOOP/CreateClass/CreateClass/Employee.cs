using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNameSpace
{
    class Employee
    {
        //fields - attributes:

        const double TAX = 0.35; /* 10% on taxes */
        public double salary;
        public int id;
        public string name,
                address,
                phone;

        //methods
        
        private double getNetSalary()
        {
            //calc net salary - salary: 1000
            double NetSalary = salary - (salary * TAX); // 1000 - 100 = 900
            return NetSalary; 
            //double type => 900.00, remember to convert it to string.Format- {0:c}
        }
        public string getEmployeeData()
        {
            string allData = "";

            allData += string.Format("Id: {0}\n", id); //int Employee.id
            allData += string.Format("Name: {0}\n", name); //string Employee.name
            allData += string.Format("Salary: {0:c}\n", salary); //double Employee.id
            allData += string.Format("Net Salary: {0:c}\n", getNetSalary());//call getNetSalary()
            allData += string.Format("Address: {0}\n", address); //string Employee.address
            allData += string.Format("Phone: {0}\n", phone); //string Employee.phone

            return allData;
        }
        public void printEmployeeData()
        {
            Console.WriteLine("Employee Info:\n{0}", getEmployeeData()); //print all info
        }
        public static void printEmployeeTerms()
        {
            Console.WriteLine("Employee Terms and Condtions\n ......"); //print all info
        }
    }
}
