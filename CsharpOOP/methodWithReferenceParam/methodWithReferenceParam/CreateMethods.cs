using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class CreateMethods
    {
        //create a normal method:
        public static string callMyMethod(string myMethodNameIs)
        {
            return "Your method name is => " + myMethodNameIs;
        }
        //create a method that accepts an array by value
        public static string displayAllNames(string[] names)
        {
            string res = "";
            res += "===================\n";
            res += "Employee Full Name is \n";
            //display a messge with all names:
            foreach(string emp in names)
            {
                res += "\t=> " + emp + "\n";
            }
            res += "===================";
            return res;
        }

        
    }
}
