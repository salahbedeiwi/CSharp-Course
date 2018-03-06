using System;
namespace Inheritance
{
    class Person
    {
        //create an attributes.
        private string _Name;
        private string _Address;
        private string _Phone;
        
        //create setter and getter
        public string name {
            get { return this._Name; }
            set { this._Name = value; }
        }
        public string address
        {
            get { return this._Address; }
            set { this._Address = value; }
        }
        public string phone
        {
            get { return this._Phone; }
            set { this._Phone = value; }
        }
        //private methods
        private string _GetPersonData()
        {
            return string.Format("=>Name: {0};=>Address: {1};=>Phone: {2}",
                        _Name, _Address, _Phone);
        }
        //Note, you can't call this function or use even if you inherit me
        private void NL()
        {
            Console.WriteLine("==========================");
        }
        //Public methods - accessed methods
        public string GetPersonData()
        {
            return _GetPersonData().Replace( ";" , "\n" );
        }

        public void PrintPersonData()
        {
            Console.WriteLine( GetPersonData() );
        }

    }
}
