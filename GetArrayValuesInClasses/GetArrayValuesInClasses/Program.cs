using System;
using EmployeeNameSpace; //call the namespace of Employee.cs
using CalculateNameSpace; //call namespace from Calcuate.cs
namespace createClass
{
    class Program
    {
        //show calculation:
        public static void calcNow()
        {
            Calculate calc = new Calculate();
            Calculate addNum = new Calculate("add", 15, 25);
            Calculate multiply = new Calculate("multiply", 15, 25);
            Calculate multiply_2 = new Calculate("times", 15, 25);
            Calculate divide = new Calculate("divide", 24, 36);
            Calculate subtract = new Calculate("subtract", 15, 25);
            Calculate somethingWrong = new Calculate("", 15, 25);

        }
        //show two int arrays are added together:
        public static void addTwoIntArrayTogether()
        {
            int[] r1 = new int[] { 1, 2, 3, 4, 5 };
            int[] r2 = new int[] { 1, 2, 3, 4, 5 };
            Calculate calcSumOfTwoArrays_1 = new Calculate(5, r1, r2);

            //2nd example
            int[] r3 = new int[] { 1, 2, 3, 4, 5 };
            int[] r4 = new int[] { 1, 2, 3 }; //note, they are not the same size
            Calculate calcSumOfTwoArrays_2 = new Calculate(5, r3, r4);

        }
        //show emplpoyee Departments:
        public static void showEmployeeDepartments()
        {
            EmployeeDepartment empDep = new EmployeeDepartment();
            empDep.numofClasses = 150;
            empDep.numOfTeachers = 15;
            empDep.deptName = "Science";

            empDep.printDeptInfo();
            //create an instant result:
            EmployeeDepartment scienceDept = new EmployeeDepartment(empDep.deptName, empDep.numofClasses, empDep.numOfTeachers);
            EmployeeDepartment mathDept = new EmployeeDepartment("Math", 15, 3);
            EmployeeDepartment chemistryDept = new EmployeeDepartment("Chemistry", 105, 32);
            EmployeeDepartment CsciDept = new EmployeeDepartment(864, 48, "Computer Science");
        }
        static void showAnEmployee()
        {

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
        }
        static void printStrArr()
        {
            string[] strNames = new string[] { "Ahmed", "Salah", "Alaa" };
            PrintStringArray pStrArr = new PrintStringArray(strNames);
            pStrArr.prntStrArr(", ");

        }
        static void printAnyArr()
        {
            object[] n = new object[] { 1, 52, 32, 98, 180, 165, 46 };
            object[] strNames = new object[] { "Ahmed", "Salah", "Alaa" };
            object[] randInfo = new object[] { "Ahmed", 65, 10.25, "x*y", "ABCDEF" };
            object[] randmix = new object[] { "Ahmed" };
            object[] emptyArray = new object[0];
            PrintAnyArrayType pNumArr = new PrintAnyArrayType(n);
            PrintAnyArrayType pNumAr2r = new PrintAnyArrayType(strNames);
            PrintAnyArrayType prandInfo = new PrintAnyArrayType(randInfo);
            PrintAnyArrayType prandmix = new PrintAnyArrayType(randmix);
            PrintAnyArrayType pmptyArray = new PrintAnyArrayType(emptyArray);
        }
        //show sum of an int array
        static void showSumOfIntArr()
        {
            int[] n = new int[] { 1, 52, 32, 98, 180, 165, 46 };
            PrintSumOfIntArray getSum = new PrintSumOfIntArray(n);
            Console.Write("{");
            foreach (int x in n)
            {
                Console.Write("{0}, ", x);
            }
            Console.Write("}");
        }
        static void Main(string[] args)
        {
            /*
             * Call all method inside this class to be fired
            */
            showAnEmployee(); //show employees Info
            showEmployeeDepartments(); //show employee departments
            calcNow(); //show all calc
            printStrArr(); //print string in array
            printAnyArr(); //print any type of array
            showSumOfIntArr(); //show sum of an int array
            addTwoIntArrayTogether(); //show sum of two int array as an array
            Console.ReadKey();
        }
    }
}