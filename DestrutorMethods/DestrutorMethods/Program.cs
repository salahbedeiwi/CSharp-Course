using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AllReservedWords
{
    class WaterMelon
    {
        //constructor method
        public WaterMelon() { Console.WriteLine("Init. WaterMelon Object"); }
        //normal method
        public void Print() { Console.WriteLine("Print() in WaterMelon"); }
        //deconstructor method
        ~WaterMelon() { Console.WriteLine("Destroy. WaterMelon Object"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Destructor is the opposite of instructors.
            WaterMelon wm;
            wm = new WaterMelon();
            wm.Print();
            //when to destroy the constructor, once it's declared,
            //then you can destroy it
            //it automatically destroy the object once created and executed.
            Console.ReadKey();
        }
    }
}
/*
Init. WaterMelon Object
Print() in WaterMelon
Destroy. WaterMelon Object
*/
