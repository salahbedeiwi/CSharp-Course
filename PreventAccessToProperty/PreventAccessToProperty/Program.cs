using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreventAccessToProperty
{
    //how to prevent an access to any property:
    //why? you may face s.t like this
    //idea, don't make the property private. if private property,
    //it will not show when creating object:
    //we want it to show, but not to access it, means not to assign it a value
    class Person
    {
        //code snippet: tab twice so auto implement current method, property, ...
        //propfull => it will make a full property and attributes
        public int MyProperty1 { get; set; } //abbreviated as "prop"
        //propfull:
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        //I Dont want anyone to assign a value to my property SSN
        //SAY I HAVE A DEFAULT SSN AND I DON'T LIKE IT TO BE CHANGED/ACCESSED OUTSIDE
        private string _SSN;
        public string SSN
        {
            get { return _SSN; } //i can access/call/invoke/pull the value
            private set { _SSN = value; } //note, i won't be able to assign it
        }
        public Person() { _SSN = "000-00-0000"; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); //show ssn by default
            p.Address = "Spring Lake Park";
            // p.SSN = ""; //error: inaccessible
            Console.WriteLine("Address: {0}", p.Address);
            Console.WriteLine("Main SSN: {0}", p.SSN); //I Can access the result, not assign it
            Console.ReadKey();
        }
    }
}
