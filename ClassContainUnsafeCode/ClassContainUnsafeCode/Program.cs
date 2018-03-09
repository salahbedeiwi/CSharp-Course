using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassContainUnsafeCode
{
    //class contain unsafe code:
    class checkSafety
    {
        //make sure to write unsafe keywrd->
        //get int address
        public static unsafe void CheckIntAddress(int i) {
            //check the pointer of i: the address of it on memory
            //int i* => pointer variable -> get the address location on memory
            //&i => i want to reach to the pointer address of that variable int i
            int* iPointer = &i;
            Console.WriteLine((int)iPointer);
            //to enable the unsafe code, so error or underline with red shows,
            //go to my main project, right click, properties, build -> enable unsafe code

        }
        //another way of writing unsafe code - check for int as well
        public static void checkForIntAdd(int i){
            //note no unsafe keywork on decalring the method
            //note i only surron the part that i like to check for unsafe code
            unsafe
            {
                int* iPointer = &i;
                Console.WriteLine((int)iPointer);
            }
            //note this isn't including on the unsafe code
            Console.WriteLine("You were checking for the int address location");
        }
        //get arry address:
        public static unsafe void GetIntArrayAddress(int[] i)
        {
            fixed (int* myI = i)
            {
                int* iPointer = myI;
                Console.WriteLine((int)iPointer);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 150;
            int i2 = 150;
            int i3 = 150;
            int i4 = 150;
            checkSafety.CheckIntAddress(i1);
            checkSafety.CheckIntAddress(i2);
            checkSafety.CheckIntAddress(i3);
            checkSafety.CheckIntAddress(i4);
            Console.WriteLine("===========================");
            //
            int[] nums = new int[] { 150, 245, 123, 543, 112 };
            checkSafety.GetIntArrayAddress(nums);
            Console.WriteLine("============================");
            checkSafety.checkForIntAdd(320);
            Console.ReadLine();
        }
    }
}
