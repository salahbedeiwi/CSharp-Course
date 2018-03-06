using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class CreateParametersWithOut
    {
        //pass parameters by out
        public static void printName(out string name)
        {
            name = "Salah";
            Console.WriteLine("Hello {0}!", name);
        }
        public static void printNameNoAssignedParam(out string name)
        {
            name = "";
            //it must be assigned, you can't write out keyword withing assigning it into value
            Console.WriteLine("Hello {0}!", name); 
        }
    }
}
