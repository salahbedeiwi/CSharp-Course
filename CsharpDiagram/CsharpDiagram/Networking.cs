using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpDiagram
{
    public class Networking : ITDepartment
    {
        public int NumOfEmp
        {
            get { return this._NumOfEmp; }
            set { this._NumOfEmp = value; }
        }

        public int NumOfServers
        {
            get{return this._NumOfServers;}
            set{ this._NumOfServers = value;}
        }

        private int _NumOfEmp;
        private int _NumOfServers;

        public void Print()
        {
            Console.WriteLine("Name: {0}\nId: {1}\n", _NumOfEmp, _NumOfServers);
        }
    }
}