using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToGoToWebsite
{
    //create class to go to new website
    class Program
    {
        static void Main(string[] args)
        {
            GoToWebsite.ToWeb("www.google.com");
            GoToWebsite.ToWeb("../");
            Console.ReadKey();
        }
    }
}
