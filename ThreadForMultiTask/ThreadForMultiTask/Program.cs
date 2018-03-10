using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ThreadForMultiTask.WaitForSeconds; //use this for calling the method right away.
namespace ThreadForMultiTask
{
    //imagine you have a departement that has 20 employees
    //this department only have one door,
    //this door size only can hold an employee at a time
    //they all come together everyday.
    //every employee must go first, then second, ....
    class HelloOne {
        public void Run() {
            for(int x = 0; x < 10; x++) Console.WriteLine("Run One"); //print 10 times
        }
    }
    class HelloTwo
    {
        public void Run()
        {
            for (int x = 0; x < 10; x++) Console.WriteLine("Run Two"); //print 10 times
        }
    }
    class WaitForSeconds
    {
        public static void Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
        public static void WaitInMs(int seconds)
        {
            Thread.Sleep(seconds);
        }
    }
    class Program
    {
        //use lock Threading
        static object obj = new object();
        static void PrintNumbers()
        {
            //note, use lock to make sure the Thread t = new Thread(method), t.Start(); work fine
            //must use lock
            //lock very much, it looks for any Thread out there, and check if any Thread have
            // a conflict with it, so it is safer
            lock (obj) //lock (""), pass anything
            {
                WaitInMs(100);//wait for .1 second
                Console.WriteLine("0123456789");
            }
        }
        static void Main(string[] args)
        {
            
            HelloOne h1 = new HelloOne();
            HelloTwo h2 = new HelloTwo();
            h1.Run();
            h2.Run();
            Console.WriteLine("===================================================");
            //note h1.Run() goes first, then h2.Run() after h1.Run() is executed
            //the idea both h1.Run() and h2.Run() not working at the same time
            //hmmmmm, can i make them run at the same time == every employee enters at
            //the same time
            //now use thread:
            Thread t1 = new Thread(h1.Run); //remember to add the namespace System.Threading;
            Thread t2 = new Thread(h2.Run); //remember to add the namespace System.Threading;
            //note: no () in the passing method.
            //but both thread will work at the same time: woooooooow
            t1.Start();
            t2.Start();
            //look at results.
            //idea: to create a multi task to be excuted at the same time.
            Console.WriteLine("===================================================");

            //can i make my thread(task) sleep or wait???
            //whenever you call something, let it wait for a while # of seconds
            Thread.Sleep(4000); //wait for 4 secs
            Console.WriteLine("You have waited for 4 seconds");
            WaitForSeconds.Wait(5);
            Console.WriteLine("You have waited for 5 seconds");
            //note i will use => using static ThreadForMultiTask.WaitForSeconds
            Wait(2);//wait for 2 seconds
            Console.WriteLine("You have waited for 2 seconds");
            Wait(3);
            Console.WriteLine("You have waited for 3 seconds");
            Wait(2);
            Console.WriteLine("===================================================");
            Console.WriteLine("You have waited for 2 seconds");
            Wait(1);
            Console.WriteLine("You have waited for 1 seconds");
            Wait(0);
            Console.WriteLine("You have waited for 0 seconds");
            
            //lock in Threading: means print it in time manner
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(PrintNumbers);
                t.Start();
                //or
                //PrintNumbers();

            }
            Console.ReadKey();
        }
    }
}
/*
Run One
Run One
Run One
Run One
Run One
Run One
Run One
Run One
Run One
Run One
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
===================================================
Run One
===================================================
Run One
Run One
Run One
Run One
Run One
Run One
Run One
Run One
Run One
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
Run Two
You have waited for 4 seconds
You have waited for 5 seconds
You have waited for 2 seconds
You have waited for 3 seconds
===================================================
You have waited for 2 seconds
You have waited for 1 seconds
You have waited for 0 seconds
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789

*/
