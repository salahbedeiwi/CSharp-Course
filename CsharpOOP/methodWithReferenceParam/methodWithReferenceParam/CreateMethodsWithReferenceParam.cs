using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class CreateMethodsWithReferenceParam
    {
        //create a method with reference param
        public static void RefMethodNum(int num)
        {
            Console.WriteLine("Number you're passing is => {0}",num);
        }
        //create a method with reference param
        public static void RefMethodNumTwo(int num)
        {
            // here i assign to my parameters == i refer to my parameters == 
            // i reference my param to have a certain value that can't be changed
            num = 170; //no matter what the user pass, it will not be changed, result = 170
            Console.WriteLine("This param has been already assigned by reference and can't be"+
                                    " changed to any assigned number => {0}", num);

        }
        public static void RefMethodNumThree(ref int num)
        {
            // here i assign to my parameters == i refer to my parameters == 
            // i reference my param to have a certain value that can't be changed
            num = 250; //no matter what the user pass, it will not be changed, result = 250
            Console.WriteLine("This param has been already assigned by reference and can't be" +
                                    " changed to any assigned number => {0}", num);

        }

        //create a method that accepts an array by reference
        public static string displayAllGames(ref string[] mygames)
        {
            string[] games = new string[] { "Soccer", "Football", "Basketball" };
            string res = "";
            res += "===================\n";
            res += "Games we have are\n";
            //display a messge with all names:
            foreach (string game in games)
            {
                res += "\t=> " + game + "\n";
            }
            res += "===================";
            return res;
        }
    }
}
