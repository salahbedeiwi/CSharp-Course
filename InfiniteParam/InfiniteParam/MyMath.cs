using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteParam
{
    class MyMath
    {
        public static int SumParam(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int SumParam(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static int SumParam(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
        //imagine i have 100's of parameters, i can't write every single param
        public static int SumAnyParam(int[] sum)
        {
            int total = 0;
            foreach(int s in sum)
            { //if numbers and int type
                if(s.GetType().Name == "Int32")
                {
                        total += s;
                }else
                {
                    return total = 0;
                }
            }
            return total;

        }
        //best way: instead of passing an array, you can directly pass param as variables
        public static int SumOfAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int s in numbers)
            {
                if(s.GetType().Name == "Int32")
                {
                    sum += s;
                }
                else
                {
                    sum = 0;
                }
            }
            return sum;
        }
        public static string ConcatinateString(params string[] x)
        {
            string y = "";
            foreach(string s in x)
            {
                if (s.GetType().Name == "String")
                    y += s+" ";
                else
                    y = "";
            }
            return y;
        }
    }
    
}
