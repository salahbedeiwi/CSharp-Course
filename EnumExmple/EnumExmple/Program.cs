using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExmple
{
    enum Colors //set of named constants
    {
        //don't define variables
        //use the name as it is
        //i can define variables but outside this enum
        Red, Green, Blue, Black, Yellow
    }
    public enum Floors { First, Second, Third, Forth, Fifth, Sixth, Seventh }
    class Employee
    {
        public int EmpNo;
        public string EmpName;
        public Colors FavColor;
        public Floors Floor; //please note, i defined string Floor to have type Floors

        //say i have 7 floors - known already, so like days in week are 7
        //like month in a year 12, it like a fact that we know and won't change
        public void PrintData() {
            Console.WriteLine("Employee Number is {0}\nName: {1}\nWorking at {2}-Floor\nFavorite Color is {3}"
                                                    , EmpNo, EmpName, Floor, FavColor);
            Console.WriteLine("====================================");
        }
    }
    class Program
    {
        static void PrintColorName(Colors colorN)
        {   
            //note, i am passing type of Colors: Colors c2 = new Colors();
            //like string name, int x, Employee emp,Colors c2
            Console.WriteLine("=>Color name is {0}", colorN);
            Console.WriteLine("====================================");
        }
        static void Main(string[] args)
        {
            //define a variable of enum Colors

            //#1:
            Colors c1;//One way of defining enum Colors
            c1 = Colors.Black;
            PrintColorName(c1);

            //#2:
            Colors c2 = new Colors(); //Another way of defining enum Colors
            c2 = Colors.Red;
            PrintColorName(c2);

            //#3:
            Colors c3 = Colors.Green; //another way of defining enum Colors
            PrintColorName(c3);

            //Define Employee Class:
            Employee e1 = new Employee();
            e1.Floor = Floors.First;
            e1.EmpName = "Salah";
            e1.EmpNo = 111;
            //NOTE HERE I AM NOT DEFINING FAVORITE COLOR:
            //=> PrintData() will take the default of Colors => first value Red
            e1.PrintData();

            Employee e2 = new Employee();
            e2.Floor = Floors.Second;
            e2.EmpName = "Imad";
            e2.EmpNo = 222;
            e2.FavColor = Colors.Green;
            e2.PrintData();

            Employee e3 = new Employee();
            e3.Floor = Floors.Third;
            e3.EmpName = "Bedeiwi";
            e3.EmpNo = 333;
            e3.FavColor = Colors.Yellow;
            e3.PrintData();

            Console.ReadKey();
        }
    }
}
/*
=>Color name is Black
====================================
=>Color name is Red
====================================
=>Color name is Green
====================================
Employee Number is 111
Name: Salah
Working at First-Floor
Favorite Color is Red
====================================
Employee Number is 222
Name: Imad
Working at Second-Floor
Favorite Color is Green
====================================
Employee Number is 333
Name: Bedeiwi
Working at Third-Floor
Favorite Color is Yellow
====================================
*/
