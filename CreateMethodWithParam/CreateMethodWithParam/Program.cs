using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMethodWithParam
{
    class Program
    {
        int z = 15;
        //private method by default - can be used inside this class program
        static void sayHello()
        {
            Console.WriteLine("Hello there!");
        }
        //create a method with parameters:
        static void getName(string nameIs)
        {
            Console.WriteLine("Hello {0}! Thanks for signing up.", nameIs);
        }

        //create student welcoming and salary
        static void getSalary(string studName, double salaryIs)
        {
            Console.WriteLine("Hello {0}! Your salary is {1:c2}", studName, salaryIs);
        }
        //create student name and his Id (optional)
        // note any param that is optional - pass it at the end of the parameters:
        // string studName = "No Name" or int studId = 0
        static void getNameAndId(string studName, int studId = 0)
        {
            Console.WriteLine("Hello {0}! Your Id is {1}", studName, studId);
        }
        //create a method that returns value
        static int getNumbers(int i)
        {
            if (i < 0)
                return 0;
            else
                return i;
        }
        //return random name
        static string getMyName(string nameIs)
        {
            try
            {
                if (nameIs.Trim() == "" || nameIs.Length == 0)
                    return "Must have a name!";
                else
                    return "Your name is " + nameIs;
            }
            catch(Exception ex)
            {
                return string.Format("Error entering name: {0}", ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //call the method.
            //get name from users and then diplay a message:
            Console.WriteLine("Enter your name?");
            string personName = Console.ReadLine();
            Console.WriteLine("=============================================");
            if(personName == "" || personName.Length < 1)
                sayHello(); //if empty, just say hello
            else
                getName(personName); //say hello to the person name

            Console.WriteLine("=============================================");
            //create an array and have names on - assume it is a db
            string[] names = {"Ahmed", "", "salah", "", "Samir", "   " };
            foreach (string eachPersonName in names)
            {
                if (eachPersonName == "" || 
                        eachPersonName.Length < 1 || 
                            eachPersonName.Trim() == "")
                    sayHello(); //if empty, just say hello
                else
                    getName(eachPersonName); //say hello to the person name
            }
            Console.WriteLine("=============================================");
            foreach (string eachPersonName in names)
            {
                if (eachPersonName == "" ||
                        eachPersonName.Length < 1 ||
                            eachPersonName.Trim() == "")
                    sayHello(); //if no name, then no salary
                else
                    getSalary(eachPersonName, 1500); //say hello to the person and salary
            }
            Console.WriteLine("=============================================");
            foreach (string eachPersonName in names)
            {
                if (eachPersonName == "" ||
                        eachPersonName.Length < 1 ||
                            eachPersonName.Trim() == "")
                    sayHello(); //if no name, then no salary
                else
                    getNameAndId(eachPersonName); //note i didn't pass the id          
            }
            Console.WriteLine("=============================================");
            foreach (string eachPersonName in names)
            {
                if (eachPersonName == "" ||
                        eachPersonName.Length < 1 ||
                            eachPersonName.Trim() == "")
                    sayHello(); //if no name, then no salary
                else
                    getNameAndId(eachPersonName, 325); //note i did pass the id          
            }
            Console.WriteLine("=============================================");
            Console.WriteLine("Enter your name?");
            personName = Console.ReadLine();
            Console.WriteLine("=============================================");
            if (personName == "" || personName.Length < 1)
                Console.WriteLine(getMyName(personName));//show result - must enter name
            else
                Console.WriteLine(getMyName(personName));//show result - person name

            Console.WriteLine("=============================================");
        }
    }
}
