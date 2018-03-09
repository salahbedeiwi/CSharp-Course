using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DisposeResources
{
    //how to dispose resourses: encapsulate resources by using
    //using keyword:
    //other using for the keyword using

    class TryMe
    {
        public static void Print()
        {
            Console.WriteLine("Hello Threr!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //using System.Io
            StreamWriter sw1 = new StreamWriter("MyFile.txt"); //create a file
            sw1.WriteLine("Welcome to my file!"); //add this line
            sw1.WriteLine("Hello, today we will talk about ....");
            sw1.WriteLine("#1: .....");
            sw1.WriteLine("#2: .....");
            sw1.WriteLine("#2: .....");
            sw1.WriteLine("#2: .....");
            sw1.WriteLine("#2: .....");
            //sw1.Close(); //now it will append everything above
            //say i like to delete the file and its content.
            sw1.Dispose(); //add everything automatically after adding everything
            //say i like to do this in a safe way and use using keyword and encapsulate my work
            //means have it all in one block, finish it then move the next statement:
            using (StreamWriter sw2 = new StreamWriter("CreateNewFile.txt"))
            {
                sw2.WriteLine("Hello there,");
                sw2.WriteLine("Hello there,");
                sw2.WriteLine("Hello there,");
                //sw2.Dispose(); //no need to write dispose() or Close() to append
                //block of code will be excuted automatically and be finished.. cooool
            }//note i can declare sw2 again, because once this code is done ,it automatically
            //clears and delete the local variable sw2

            //can i create more that one instance/files
            using (StreamWriter sw2 = new StreamWriter("CreateNewFile2222.txt"))
            using (StreamWriter sw3 = new StreamWriter("CreateNewFile3333.txt"))
            using (StreamWriter sw4 = new StreamWriter("CreateNewFile4444.txt"))
            {
                sw2.WriteLine("Hello there,");
                sw2.WriteLine("Hello there,");
                sw2.WriteLine("Hello there,");
                sw3.WriteLine("Hello there,");
                sw3.WriteLine("Hello there,");
                sw3.WriteLine("Hello there,");
                sw4.WriteLine("Hello there,");
            }//it will dispose/distroy three sw2,sw3 and sw4 once executed.

            //can i use using with class and declaration? only iDisposible Interface
            //Fonts and Files
            Console.ReadLine();
        }
    }
}
