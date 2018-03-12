using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InAndOutInGenericModifiers
{
    class MyGent<g> {}
    //in and out only goes on interface/delegate
    //make it generic interface
    //Use in keyword, for string == object
    interface MyI<in t> { } //note in keyword will make str = obj
    class MyC<xType> : MyI<xType> {
        //let xType be the type for both Class MyC 
        //when implementing, must be same type as well.
        //also MyC must have a passed return type
        //since it inherits from MyI interface

    }
    //Use out keyword, for object == string
    interface MyO<out s> { }
    class MyOc<sType> : MyO<sType> { }
    class Program
    {
        static void Main(string[] args)
        {
            /*
                MyGent<string> str = new MyGent<string> { };
                MyGent<object> obj = new MyGent<object> { };
                //can i say str == obj
                str = obj;
                //can i say obj == str
                obj = str;
            */
            //create an object of the interface
            //Note, get all common info MyI -> MyC
            MyI<string> str = new MyC<string> { };
            MyI<object> obj = new MyC<object> { };
            str = obj;//in keyword, makes your store object in string
            //note now both str and obj are now objects ---- <in t>
            Console.WriteLine(str);//InAndOutInGenericModifiers.MyC`1[System.Object]
            Console.WriteLine(obj);//InAndOutInGenericModifiers.MyC`1[System.Object]
            //get to use out instead of in  --- <out type>
            MyO<string> str_out = new MyOc<string> { };
            MyO<object> obj_out = new MyOc<object> { };
            obj_out = str_out;//out keyword, makes your store string in object
            Console.WriteLine(str_out);//InAndOutInGenericModifiers.MyOc`1[System.String]
            Console.WriteLine(obj_out);//InAndOutInGenericModifiers.MyOc`1[System.String]
            Console.ReadKey();
        }
    }
}
