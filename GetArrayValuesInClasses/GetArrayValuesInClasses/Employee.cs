using System;

namespace EmployeeNameSpace
{
    class EmployeeInfo
    {
        //attributes:
        const double TAX = 0.35;
        public int id;
        public double salary;
        public string name, address, phone;

        //methods:
        private double getNetSalary()
        {
            double finalSalary = salary - (TAX * salary);
            return finalSalary;
        }
        private string employeeData()
        {
            string empData = "";
            empData += string.Format("\t\tId: {0}\n", id);
            empData += string.Format("\t\tName: {0}\n", name);
            empData += string.Format("\t\tAddress: {0}\n", address);
            empData += string.Format("\t\tPhone: {0}\n", phone);
            empData += string.Format("\t\tSalary: {0:c}\n", salary);
            empData += string.Format("\t\tNet Salary: {0:c}\n", getNetSalary());
            return empData;
        }
        public void printEmployeeData()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Employee Info:\n{0}", employeeData());
            Console.WriteLine("=======================================");
        }
        //constructors:
        public EmployeeInfo()
        {
            Console.WriteLine("You have fired an Employee Info Class");
        }
        public EmployeeInfo(string name, out int num)
        {
            num = 105;
            Console.WriteLine("Id #{1}-({0}) have created an Employee Departments!", name, num);
        }
        public EmployeeInfo(string name = "Customer")
        {
            Console.WriteLine("Welcome {0}!", name);
        }
    }
    class EmployeeDepartment
    {
        //attributes:
        public string deptName;
        public int numofClasses, numOfTeachers;

        //methods:
        public void printDeptInfo()
        {
            string deptData = "";

            deptData += string.Format("Department Name: {0}\n", deptName);
            deptData += string.Format("# of Classes: {0}\n", numofClasses);
            deptData += string.Format("# of Teachers: {0}\n", numOfTeachers);

            Console.WriteLine("====== Department Info =======\n{0}", deptData);
        }

        //constructors: fires once you create an instance of EmployeeDepartment
        public EmployeeDepartment()
        {
            Console.WriteLine("You have created an Employee Departments!");
        }
        public EmployeeDepartment(string deptartmentName, int numberOfClasses, int numberOfTeacheres)
        {
            string deptData = "";

            deptData += string.Format("Department Name: {0}\n", deptartmentName);
            deptData += string.Format("# of Classes: {0}\n", numberOfClasses);
            deptData += string.Format("# of Teachers: {0}\n", numberOfTeacheres);

            Console.WriteLine("====== Department Info =======\n{0}", deptData);
        }
        public EmployeeDepartment(int numberOfClasses, int numberOfTeacheres, string deptartmentName)
        {
            //this refered to the class
            deptName = deptartmentName; // assign deptartmentName's value to this.deptName
            this.numOfTeachers = numberOfTeacheres;
            this.numofClasses = numberOfClasses;
            //this will match the parameters passed by value with the method printDeptInfo() param
            printDeptInfo();
        }

    }
}
/*
 *   use of EmployeeDepartment Class
 *  EmployeeDepartment empDep = new EmployeeDepartment();
    empDep.numofClasses = 150;
    empDep.numOfTeachers = 15;
    empDep.deptName = "Science";

    empDep.printDeptInfo();
    //create an instant result:
    EmployeeDepartment scienceDept = new EmployeeDepartment(empDep.deptName, empDep.numofClasses, empDep.numOfTeachers);
    EmployeeDepartment mathDept = new EmployeeDepartment("Math", 15, 3);
    EmployeeDepartment chemistryDept = new EmployeeDepartment("Chemistry", 105, 32);
    EmployeeDepartment CsciDept = new EmployeeDepartment(864, 48, "Computer Science");
*/
/*     use of EmployeeInfo Class
     EmployeeInfo emp = new EmployeeInfo();
            object[] empData = new object[] {15, "Salah Bedeiwi", "612-644-1634",
                                               "361 81st Ave NE, Spring Lake Park, MN 55432",
                                                 80000.75
                                            };
    emp.id = (int)empData[0]; //id is a field int type
    emp.name = (string)empData[1];
    emp.phone = (string)empData[2];
    emp.address = (string)empData[3];
    emp.salary = (double)empData[4];
    emp.printEmployeeData();
    //fire another constructor
    EmployeeInfo emp2 = new EmployeeInfo(emp.name, out emp.id);
    EmployeeInfo emp3 = new EmployeeInfo(emp.name);
    EmployeeInfo emp4 = new EmployeeInfo("Sayed");

*/
