using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulations
{
    class Program
    {
        static void Main(string[] args)
        {

            //to call an encapsulation, create an instance
            EncapsulatedClass1 n1 = new EncapsulatedClass1();
            //set attributes
            n1._Age = 15; //note the set/get the only accessible info
            n1._ID = 20;
            n1._Name = "Salah";
            string myBonusIs = Convert.ToString(n1.BonusIs(n1._Age));
            //get attributes, means after i assign it
            Console.WriteLine("#{3} - {2}! because your age is {0}, then you have a bonus of {1:c2}", 
                                    n1._Age, myBonusIs,n1._Name, n1._ID);
            EncapsulatedClass1 n2 = new EncapsulatedClass1();
            n2._Age = 19; // > 18
            n2._ID = 49;
            n2._Name = "Bedeiwi";
            //string myBonusIsn2 = Convert.ToString(n2.BonusIs(n2._Age));
            Console.WriteLine("#{3} - {2}! because your age is {0}, then you have a bonus of {1:c}",
                                    n2._Age, n2.BonusIs(n2._Age), n2._Name, n2._ID);
            Console.ReadKey();
        }
    }
    /*
     * Idea of Encapsulations: I need to perform a specific task
     * But i don't want that you access the attributes/methods 
     * directly
     * I encapsulate the entire method
     * 
     * like: you ran out gas on your car, it shows that you need to
     * fill your car with a gas. you don't have to understand/care
     * what works inside that method that shows you that you ran out
     * of gas, but you need to understand that you need gas on ur car
     * 
     * 
     */
    class EncapsulatedClass1
    {
        //can't directly access it
        //you can't directrly set these values when creating an instance
        //you can only use the set and get below
        private int id;
        private string name;
        private int age;
        private const double bonus = 500.99; //note i won't decalare set/get
        //get & set attributes:
        //attributes means no ()
        //also these are features to set and get attributes {}
        //only use set and get for what you want to do when creating an instance
        //means if you don't want anyone to access the id, then don't set/get it
        //only use it on methods as you like
        public int _ID
        {
            get { return this.id; } //return the value of id when i call it
            set { this.id = value; } //assign/set a value to id
        }

        public string _Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int _Age
        {
            get { return this.age; }
            set
            {
                if (value >= 18) this.age = value;
                else this.age = 0; //make it 0
            }
        }
        //can I have a get/set with different retun value?
        /* Wrong, must be string "int _Name " as this.name type
        public int _Name
        {
            get { return this.name = _Name; }
            set { this.name = _Name; }
        }
        */
        public string CapitalizeName(string name)
        {
            return name.ToUpper(); //capitalize it
        }
        public int GetId(int id)
        {
            return id; // return id
        }
        public double BonusIs(int age)
        {
            if (age >= 18)
                return Convert.ToDouble(bonus); //return bonus: 500.00
            else
                return Convert.ToDouble(0); //return 0.00
        }
    }
}
