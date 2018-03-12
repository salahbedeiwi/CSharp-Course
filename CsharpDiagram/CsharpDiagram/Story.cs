using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpDiagram
{
    public struct Story
    {
        public Story(string about)
        {
            Console.WriteLine("You have created story class- {0}", about);
        }

        public string About
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public DateTime Since
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double Salary
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string _about()
        {
            throw new System.NotImplementedException();
        }

        public DateTime _Since()
        {
            throw new System.NotImplementedException();
        }
    }
}