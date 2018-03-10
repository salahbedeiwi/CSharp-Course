using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
    class Program
    {
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

            //idea: create a multi task to be excuted at the same time.
            
            Console.ReadKey();
        }
    }
}
/*Run One
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
Run Two
Run Two
Run Two
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
Run One
*/