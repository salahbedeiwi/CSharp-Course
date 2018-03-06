using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        //create method with references:




        //create a normal private method from same class:
        static string callMyName(string myNameIs)
        {
            return "Your name is => " + myNameIs;
        }
        //MAIN RUNNING METHOD FOR WHOLE PROGRAM
        //void means no return type
        static void Main(string[] args)
        {
            //call a method from this class - return type string (pass string)
            Console.WriteLine("************************************************");
            Console.WriteLine(callMyName("Salah"));
            Console.WriteLine("************************");
            //call a method from CreateMethod class - return type string
            Console.WriteLine(CreateMethods.callMyMethod("callMyMethod"));
            Console.WriteLine("************************************************");
            //call a method from CreateMehodsWithReferenceParam => - return type void
            //very much just call the method
            CreateMethodsWithReferenceParam.RefMethodNum(150);
            Console.WriteLine("************************************************");
            //call a method from CreateMehodsWithReferenceParam, assign an int num2
            //note you can change the value of num2 and it works fine
            int num2 = 250;
            CreateMethodsWithReferenceParam.RefMethodNum(num2);
            Console.WriteLine("************************************************");
            //call a method from CreateMehodsWithReferenceParam, assign an int num3
            //note it will not accept num3
            int num3 = 250; //it will be 170, because it is a reference parameter
            Console.WriteLine("My number you are passing before using RefMethodNumTwo method is => " + num3); //no it doesn't override the pass parameters by reference
            CreateMethodsWithReferenceParam.RefMethodNumTwo(num3);
            //question now: what's my num3, is it 250 or 170 after i print the previous method
            //let's print it => 250
            Console.WriteLine("My number after using RefMethodNumTwo method is => " + num3); //no it doesn't override the pass parameters by reference
            Console.WriteLine("************************************************");
            int newNum = 785;
            //note here i will be using ref on my method => RefMethodNumThree
            Console.WriteLine("My number you are passing before using RefMethodNumThree method is => " + newNum); //no it doesn't override the pass parameters by reference
            CreateMethodsWithReferenceParam.RefMethodNumThree(ref newNum);
            //question now: what's my num3, is it 250 or 170 after i print the previous method
            //let's print it => 250
            //note this newNum after Printing -> why changed, because i passed ref int x on RefMethodNumThree mthd
            Console.WriteLine("My number after using RefMethodNumThree method is => " + newNum);
            Console.WriteLine("************************************************");
            //display all names for method => displayAllNames
            //string array by value
            string[] studentNames = new string[] { "Salah", "Imad", "Bedeiwi" };
            Console.WriteLine(CreateMethods.displayAllNames(studentNames)); //show all names
            Console.WriteLine("************************************************");
            //string array by reference
            string[] games = new string[] { "Tennis", "Ping Pong", "Swimming" , "Swimming 2" };
            Console.WriteLine(CreateMethodsWithReferenceParam.displayAllGames(ref games)); 
            //show all games, not it is ref
            //note, it is a ref, so it will display only what i refered only on my method.
            Console.WriteLine("************************************************");
            //pass parameters with out
            string name; //it will only accepts Salah, not i didn't assign any value
            //also note,by passing parameters with out, no need to assign a value that you are passing
            //even if it is empty, but i did assign it on my method as default => salah
            oop.CreateParametersWithOut.printName(out name);
            Console.WriteLine("************************************************");
            //say i didn't assign any value on my method and i didn't also assign the string i am passing:
            string strName;
            //it must be assigned, you can't write out keyword withing assigning it into value
            //so i did assign it to value
            oop.CreateParametersWithOut.printNameNoAssignedParam(out strName);
            Console.WriteLine("************************************************");

            Console.ReadKey();
        }
    }
}
