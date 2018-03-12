using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyNameSpace;
namespace CsharpDiagram
{
    public class ITDepartment : Company, Customers
    {
        private string _DeptName;
        private int _DeptOfficeNum;
        private Floors _FloorNum;
        private string custCity;
        private string custAdd;
        string Customers.City {
            get
            {
                return this.custCity;
            }

            set
            {
                this.custCity = value;
            }
        }
        string Customers.Address {
            get
            {
                return this.custAdd;
            }

            set
            {
                this.custAdd = value;
            }
        }
        public ITDepartment()
        {
            BestName = "AEP-458";
            Console.WriteLine("Init - {0}............IT Department!", BestName);
        }

        ~ITDepartment()
        {
            Console.WriteLine("Finishing............IT Department!");
        }

        public Floors FloorIs
        {
            get
            {
                return this._FloorNum;
            }

            set
            {
                this._FloorNum = value;
            }
        }
        public void PrintMngOffice(int h, int w,string c, string add)
        {
            h = Height;
            w = Weight;
            BDay = DateTime.Now;
            this.custAdd = add;
            this.custCity = c;
            Console.WriteLine("Bday: {0}\n. Height is {1} and Weight is {2}\nAddress: {3}\nCity {4}"
                                , BDay, h, w, c, add);
        }
    }
}