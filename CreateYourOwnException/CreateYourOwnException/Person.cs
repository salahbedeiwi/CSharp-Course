using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourOwnException
{
    class Person
    {
        private string _Name;

        public string Name
        {
            get { return this._Name; }
            set {  this._Name = value; }
        }

        public Person(string nm)
        {
            //say i don't want to accept an empty nm
            //show error:
            //assign this passing nm to _Name: why? two reasons:
            //1. whenever i create an object, i can easily get the value of Person.Name directly
            //2. if i assign it Person.Name to new value, it will override it.
            //if (nm.Trim() == "") //if empty
            //    throw new Exception("Can't Have Field Empty"); 
            //note Exception is the type, it could be IndexOutOfRangeException, ... choose the type of exception
            //if s.t goes wrong, throw a new exception handler for me
            //an exception handler will handle the error and show specific info 2 the users to let
            //them know that they need to fix some bug/errors.

            /*
            Way #1
            if (nm.Trim() == "") throw new Exception();
            Way #2
            if (nm.Trim() == "") throw new Exception("Can't Have Field Empty");
            Way #3: create your own exception: wow - see class EmptyFiledException

            */

            this._Name = nm;
            if (nm.Trim() == "") throw new EmptyFiledException(); //from new Exception i created
            else Console.WriteLine("You passed a {0}", nm);
        }
        public void PrintName()
        {
            Console.WriteLine("You have enter your name => {0}", _Name);
        }
    }
}
