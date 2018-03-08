using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNewEvent
{

    class Program
    {
        //how to create a new event:
        delegate void MyDel(); //my delegate
        //declare an event - must have anonymoud method:
        //event keyword, MyDel() method, then Event Name
        static event MyDel MyEvent1; //Creatd an event - private
         
        public delegate void MyDel2222(); //my delegate anonymous method
        public static event MyDel2222 Event2; //public event
        // =>exaclty like => MyDel2222 Event2 = delegate { };

        static void Main(string[] args)
        {
            //note if i am calling an event inside this static method, then 
            //even must be static too
            //to call an event, must set an instance of an object
            //note the += means to add it to the event
            Event2 += delegate { Console.WriteLine("Event created!"); };
            Event2 += delegate { Console.WriteLine("Event created!"); };
            Event2 += delegate { Console.WriteLine("Event created!"); };
            Event2();
            //here once i call MyEvent1(), will only print last result
            MyEvent1 = delegate { Console.WriteLine("Another Event created -- 111111!"); };
            MyEvent1 = delegate { Console.WriteLine("Another Event created -- 222222!"); };
            MyEvent1 = delegate { Console.WriteLine("Another Event created -- 333333!"); };
            MyEvent1();
            //Event2 = delegate { };
            //create anonymous method
            MyDel2222 Event333 = delegate { Console.WriteLine("That's method"); };
            Event333(); //local variable

            Console.ReadKey();
        }
    }
}
/*
Event created!
Event created!
Event created!
Another Event created -- 333333!
That's method

     */
