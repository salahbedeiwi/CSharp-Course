using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass
{
    class PrintStringArray
    {
        //print string array
        string[] content;
        //default constructor: pass an array to it.
        public PrintStringArray(string[] myStringArray)
        {
            this.content = myStringArray;
        }
        //print === void
        public string getStringArray(string seperatorStr)
        {
            string strArr = "";
            foreach (string s in content)
            {
                strArr += s + seperatorStr;
            }
            return strArr;
        }
        public void prntStrArr(string seperatorStr)
        {
            Console.WriteLine(getStringArray(seperatorStr));
        }
        //constructor but int array
        public PrintStringArray(object[] nums)
        {
            Console.WriteLine("=======================================");
            PrintNumsInArray(nums);
            Console.WriteLine("\n=======================================");
        }
        //print an array of nums, strings, objects, ....
        private void PrintNumsInArray(object[] nums)
        {
            foreach (object n in nums)
            {
                Console.Write("{0}, ", n);
            }
        }

    }
    class PrintAnyArrayType
    {
        //constructor but can accept in array type - object could be int, double, string, mix of data
        public PrintAnyArrayType(object[] nums)
        {
            if (nums.Length >= 1) //atleast have on element on the array
            {
                Console.WriteLine("=========== Array Elements: {0} ===========", nums.Length);
                PrintNumsInArray(nums);
                Console.WriteLine("\n=======================================");
            }
            else
            {
                Console.WriteLine("You must pass any value on your array");
                Console.WriteLine("=======================================");
            }
        }
        //print an array of nums, strings, objects, ....
        private void PrintNumsInArray(object[] nums)
        {
            foreach (object n in nums)
            {
                Console.WriteLine("Objects=> {0}; ", n);
            }
        }
    }
    class PrintSumOfIntArray
    {
        public PrintSumOfIntArray(int[] r)
        {
            Console.WriteLine("=======================================");
            //show array:
            Console.WriteLine("Sum of your int array is => {0}", PrintSumOfIntArrayMethod(r));
            Console.WriteLine("=======================================");
        }
        private int PrintSumOfIntArrayMethod(int[] intArr)
        {
            int results = 0;
            foreach (int eachData in intArr)
            {
                results += eachData;
            }
            return results; //return the total sum of an int array
        }
    }
}