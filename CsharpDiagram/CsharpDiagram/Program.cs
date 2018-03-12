using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyNameSpace;
namespace CsharpDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Start drawing the code : project -> add new item -> class diagram 
            //-> save as -> Company.cd
            // Company.cd is written in XML
            Company.Name = "AEP";
            Company.Id = 150;
            Company.Print();
            ITDepartment IT = new ITDepartment();
            IT.BestName = "E-Commerce";
            IT.BDay = DateTime.Now;
            IT.FloorIs = Floors.First;
            IT.Height = 210;
            IT.Weight = 150;
            Customers cus = new ITDepartment();
            cus.City = "San Fransisco";
            cus.Address = "123 4th ave";
            IT.PrintMngOffice(IT.Height, IT.Weight, cus.City, cus.Address);
            IT.PrintMngOffice(IT.Height, IT.Weight, cus.City, cus.Address);
            Console.ReadKey();
            
        }
    }
}
