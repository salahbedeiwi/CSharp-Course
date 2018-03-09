using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToGoToWebsite
{
    class GoToWebsite
    {
        private delegate void _ToWeb(string url);
        private static void Run(string url)
        {
            //i can also validate the url to make sure it is url
            System.Diagnostics.Process.Start(url);
        }
        public static void ToWeb(string url)
        {
            //#1: way to do it: open url, filename, ...
            //System.Diagnostics.Process.Start(url);

            //#2: second way:
            _ToWeb toweb = Run; //assign the delegate to Run method
            toweb(url);
        }
    }
}
