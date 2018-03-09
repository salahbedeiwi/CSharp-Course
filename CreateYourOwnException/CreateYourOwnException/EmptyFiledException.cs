using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourOwnException
{
    class EmptyFiledException : Exception
    {
        //i will create my own exception and give it a name
        //to make this new exception work, this class must inherit from the 
        //main Exception,any exception type i like, so it will override info there for me.
        //one once inherited, EmptyFiledException is an exception now
        //Message = "My New Error"; //won't work, readonly Message Property from Exception
        //so the solution is to override it below

            //must override it, type of Message is String, Same Name
            //remember how we override a method from class to class, using override
            //also Message is virtual in Exception class, it could be overriden here
        public override string Message 
        {
            get
            {
                return "Error-1: Can't Leave Field Empty! Must Enter String Data.";
            }
        }
        //i can overrride any property, methods on Exception here in new EmptyFiledException
        public override string Source
        {
            get
            {
                return "Error-2: Exception Source Name: -> " + base.Source;
            }

            set
            {
                base.Source = value;
            }
        }
        //idea i can get all fields, method of Exception that i inherited from and 
        //override anything that i like as i long as i know what i am doing.

    }
}
