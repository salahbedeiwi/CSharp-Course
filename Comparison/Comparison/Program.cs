using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  equal == : same value
             *  not equal != : not equal to the compared value
             *  greater than  > : greater than the compared value
             *  greater than and  equal >= : greater than "or" equal to the compared value
             *  less than <: less than the compared value
             *  less than and equal <= : less than "or" equal to the compared value
            */

            Console.WriteLine("========== Comparision =========");
            int minVal = 10,
                maxVal = 15;

            bool minAndMaxEqual, 
                 minGreaterThanMax,
                 MaxGreaterThanMin,
                 minValNotEqualToTen;

            minAndMaxEqual = minVal == maxVal; //are they equal
            minGreaterThanMax = minVal > maxVal; //min > max
            MaxGreaterThanMin = maxVal > minVal;//max > min
            minValNotEqualToTen = minVal != 10;

            Console.WriteLine("minVal:{0} , maxVal:{1}", minVal, maxVal);
            Console.WriteLine("minVal == maxVal => " + minAndMaxEqual);
            Console.WriteLine("minVal > maxVal => " + minAndMaxEqual);
            Console.WriteLine("maxVal > minVal => " + MaxGreaterThanMin);
            Console.WriteLine("Does MinValue not equal to {0} => {1}",
                                                     minVal, minValNotEqualToTen);













        }
    }
}
