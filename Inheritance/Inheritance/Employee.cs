using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee :Person
    {
        private string _Job;
        public string job
        {
            get { return _Job; }
            set { this._Job = value; }
        }
        private string JobTitle()
        {
            return _Job;
        }
        public void EmployeeJobTitle()
        {
            Console.WriteLine("=>Job: {0}", _Job);
        }
    }
}
