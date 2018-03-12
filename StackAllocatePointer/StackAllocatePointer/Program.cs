using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAllocatePointer
{
    //say you like to work with dll 
    //learn how to find the pointer.

    class Test
    {
        //accept unsafe code, properties -> build ->accept unsafe code. save work
        //The stackalloc keyword is used in an unsafe code context 
        //to allocate a block of memory on the stack
        public static unsafe void Run() {
            int i1 = 56, i2 = 120;
            int* iPointer = &i1; //pointer that allocates the value of i1
            int* iPointer_2 = &i2; //pointer == i1
            Console.WriteLine(iPointer->ToString());//to make pointer int as a string
            Console.WriteLine(iPointer_2->ToString());//to make pointer int as a string
            //??????
            //can i do the same above in int[] ???
            /*
            int[] nums = new int[5];
            int* num_pointer = &nums;//wrong
            */
            const int arraySize = 5;
            int* MyIntArrPointer = stackalloc int[arraySize]; //now allocate 5 spots for int arr
            int* newIntPointer = MyIntArrPointer;
            newIntPointer[0] = 5;
            MyIntArrPointer[1] = 4;
            newIntPointer[2] = 3;
            newIntPointer[3] = 2;
            MyIntArrPointer[4] = 1;
            Console.WriteLine(newIntPointer[0]);
            Console.WriteLine(MyIntArrPointer[1]);
            Console.WriteLine(newIntPointer[2]);
            Console.WriteLine(newIntPointer[3]);
            Console.WriteLine(MyIntArrPointer[4]);
            int age = 150;
            int* myStrPointer = &age; Console.WriteLine(myStrPointer->ToString());
            //shortcut: int* MyIntArrPointer = stackalloc int[arraySize];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test.Run(); //56
        }
    }
}
