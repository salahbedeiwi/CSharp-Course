using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpDiagram
{
    public abstract class ManagmentOffice
    {
        private int _Height;
        private int _Weight;
        private DateTime _bDay;
        private const int Constant = 1;

        public ManagmentOffice()
        {
            Console.WriteLine("Init.... Abstract Class");
        }

        ~ManagmentOffice()
        {
            Console.WriteLine("Destroy.... Abstract Class");
        }

        public int Height
        {
            get
            {
                return this._Height;
            }

            set
            {
                this._Height = value;
            }
        }

        public int Weight
        {
            get
            {
                return this._Weight;
            }

            set
            {
                this._Weight = value;
            }
        }
        public DateTime BDay
        {
            get
            {
                return this._bDay;
            }

            set
            {
                this._bDay = value;
            }
        }
    }
}