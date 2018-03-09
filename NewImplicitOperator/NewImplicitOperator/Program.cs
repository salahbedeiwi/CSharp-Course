using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewImplicitOperator
{
    // new implicit/complete/perfect operator : ضمني
    //create a new class that convert to any type automatically
    class Digit
    {
        public double val;
        //double d = new Digit(); //hmmmmmmmmmmmmmmmm - can you convert?
        public Digit(double v)
        {
            this.val = v;
        }
        //invent a new implicit operate that accepts Digit : that's not a method
        public static implicit operator double(Digit d)
        {
            return d.val; // public double val; return same type
        }
        //Digit d1 = 17.98
        public static implicit operator Digit(double d)
        {
            return new Digit(d); // public double val; return same type
        }
        //convert any to int
        //public int intVal;
        //public Digit(int v)
        //{
        //    this.intVal = v;
        //}
        //public static implicit operator int(Digit i)
        //{
        //    return i.intVal;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            double d = 15.55;
            //say i give him an int
            d = 77; //hmmmmmmm -> this value should be int
            int x = 55;
            double f = x; //that's an implicit conversion.
            //can i do this in class? and How?
            //can i do the opposite from double to int?? hmm
            double j = 15.54;
            int i3 = (int)j; ///what's happening here - here comes the cast
            //how to invent an implict class to convert for it automatically
            Digit d23 = new Digit(15.65);
            double kjlks3232 = 15.874;
            Console.WriteLine(d23);
            Console.WriteLine(d23.GetType().Name);
            Console.WriteLine(kjlks3232);
            Console.WriteLine(kjlks3232.GetType().Name);
            Console.ReadKey();

        }
    }
}
