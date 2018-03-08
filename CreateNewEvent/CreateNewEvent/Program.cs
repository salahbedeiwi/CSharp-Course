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
         
        public delegate void MyDel2222(); //my delegate
        public static event MyDel2222 Event2; //public

        static void Main(string[] args)
        {
            //note if i am calling an event inside this static method, then 
            //even must be static too
            //to call an event, must set an instance of an object

            Event2 += delegate { Console.WriteLine("Event created!"); };
            Event2();

            MyEvent1 = delegate { Console.WriteLine("Event created!"); };
            MyEvent1();
            //Event2 = delegate { };

            Console.ReadKey();
        }
    }
}
