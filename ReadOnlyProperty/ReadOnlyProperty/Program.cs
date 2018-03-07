using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyProperty
{
    //how to make a property is read only
    class CalcBirthDay
    {
        //attributes
        private readonly int _CurrentYear; //you can read the value only
        //i can only assign it a value inside this class
        //property
        public int CurrentYear
        {
            get { return this._CurrentYear; }
            //note i like this property to be read only. 
            //you can access it but can't assign it a value
            //step #1: comment or unuse set { this._CurrentYear = value; }
            //step #2: private readonly int _CurrentYear; above
            //set { this._CurrentYear = value; }
        }
        //constructor: 
        public CalcBirthDay()
        {
            //whenever you create an object of this class, assign 
            //current year to be exact current real year
            _CurrentYear = DateTime.Now.Year; //get current year
        }
        public int Calc(int yearOfBirth)
        {
            return _CurrentYear - yearOfBirth; //2018-1988 = 30
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalcBirthDay cbd = new CalcBirthDay();
            //idea is to call cbd.CurrentYear as to get the value only.
            //we can't assign it (set) any value. only use initialized value
            //cbd.CurrentYear = 2018; //wrong => can't be assigned
            int myDofB = 1988;
            int calcNow = cbd.Calc(myDofB);
            Console.WriteLine("You are {0} year old!", calcNow);
            Console.ReadKey();
        }
    }
}
