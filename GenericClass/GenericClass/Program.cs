using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    /*
     * how to create a generic class?
     * class that i control the type of it
     * I like to invent/create types like string, int, .....
     * class MyValue <add here any type i like>
     * class MyValue <int>
     * class MyValue <type>
     * class MyValue <mango>
     * class MyValue <Mango>
     * class MyValue <7amda>
     * Idea, inside the class: declare of a variable of the type that you passed
     * you can print it, do whatever you like
     * like 
    
    */
    class AnyFruit <Fruit>
    {
        // private int x; same idea int is a type, so Mango is a type i invented
        //create an attribute of the type passed: 
        private readonly Fruit m;
        private Fruit k;
        //create a property setter and getter:
        public Fruit M { get {return this.m; } } //readonly
        public Fruit K { get {return this.k; } set { this.k = value; } }
        //create a constructor:
        public AnyFruit(Fruit c)
        {
            this.k = c; //means whenever you assign a value to k, have equal to the value for c
            Console.WriteLine("You have passed a variable {0} that is type of {1}!", c, this.k.GetType().Name);
        }
        public AnyFruit()
        {
            Console.WriteLine("You have created an object of class - {0}"
                                            , this.GetType().Name);
        }
        //create a method:
        public void PrintTypeAndValue() {
            //print the type of k and the value of k => it will figure out the type once you create an object
            Console.WriteLine("Type: {0}. Value is {1}", this.k.GetType().Name, this.k);
        }
    }
    class AnyVegetable<Vege>
    {
        // private int x; same idea int is a type, so Mango is a type i invented
        //create an attribute of the type passed: 
        private readonly Vege m;
        private Vege k;
        //create a property setter and getter:
        public Vege M { get { return this.m; } } //readonly
        public Vege K { get { return this.k; } set { this.k = value; } }
        //create a constructor:
        public AnyVegetable(Vege c)
        {
            this.k = c; //means whenever you assign a value to k, have equal to the value for c
            Console.WriteLine("You have passed a variable {0} that is type of {1}!", c, this.k.GetType().Name);
        }
        public AnyVegetable()
        {
            Console.WriteLine("You have created an object of class - {0}"
                                            , this.GetType().Name);
        }
        //create a method:
        public void PrintTypeAndValue()
        {
            //print the type of k and the value of k => it will figure out the type once you create an object
            Console.WriteLine("Type: {0}. Value is {1}", this.k.GetType().Name, this.k);
        }
    }
    class MixVegeFruit<MixVege, MixFruit>
    {
        
        private MixVege _Vege;
        public MixVege Vege { get { return this._Vege; } set { this._Vege = value; } }
        private MixFruit _Fruit;
        public MixFruit Fruit { get { return this._Fruit; } set { this._Fruit = value; } }
        //create a constructor: must accepts one param
        public MixVegeFruit(MixVege v, MixFruit f)
        {
            this._Vege = v;
            this._Fruit = f;
            Console.WriteLine("You have passed two items \n#1- Name:{0}, Type:{1}\n#2: Name:{2}, Type:{3}!"
                                        , v, this._Vege.GetType().Name, f, this._Fruit.GetType().Name);
        }
        //create a method:
        public void PrintTypeAndValue()
        {
            Console.WriteLine("#1- Name:{0}, Type:{1}\n#2: Name:{2}, Type:{3}!"
                                        , _Vege, this._Vege.GetType().Name, _Fruit, this._Fruit.GetType().Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of AnyFruit:

            //constructor with parameters will work here
            //note the parameter i am passing, will have the same value as m since i defined that in class
            Console.WriteLine("================================================");
            AnyFruit<object> f333 = new AnyFruit<object>("Fruit Punch"); //make the type of this an object
            f333.PrintTypeAndValue();
            Console.WriteLine("================================================");
            //f111.M = "Banana"; - readonly - can't assigned
            AnyFruit<string> f111 = new AnyFruit<string>("Banana");//make the type i create is string
            f111.K = "Watermelon"; //note this will override banana
            f111.PrintTypeAndValue();
            Console.WriteLine("================================================");
            AnyFruit<int> f555 = new AnyFruit<int>(155) { }; //make the type of this an object
            f555.PrintTypeAndValue();
            Console.WriteLine("================================================");
            //normal constructor will work here:
            AnyFruit<int> f222 = new AnyFruit<int>() { }; //make the type of this string
            f222.K = 654; //note, since type is int, i only declar int - woooooooooow
            //i can assign any type and change the type of all properties, methods, .... that's why it is generic
            AnyFruit<object> f444 = new AnyFruit<object> { }; //make the type of this an object

            Console.WriteLine("================================================");
            //class AnyVegetable with param
            AnyVegetable<string> carrot = new AnyVegetable<string>("Carrot");
            carrot.PrintTypeAndValue();
            Console.WriteLine("================================================");
            //class AnyVegetable without param
            AnyVegetable<object> justFruit = new AnyVegetable<object>() { };
            carrot.PrintTypeAndValue();

            Console.WriteLine("================================================");
            MixVegeFruit<string, string> mix = new MixVegeFruit<string, string>("Carrot", "Mango");
            Console.WriteLine("================================================");
            mix.PrintTypeAndValue();
            Console.WriteLine("================================================");
            MixVegeFruit<int, int> mix_num = new MixVegeFruit<int, int>(153, 153);
            //change the values:
            mix_num.Fruit = 102; mix_num.Vege = 125;
            Console.WriteLine("================================================");
            mix_num.PrintTypeAndValue();
            Console.ReadKey();
        }
    }
}
