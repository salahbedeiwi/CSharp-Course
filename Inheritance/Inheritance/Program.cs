using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using System.Text.RegularExpressions;
namespace Inheritance
{
    class Program
    {
        static void p1()
        {
            //create person 1
            Person p1 = new Person();
            //set & filter name
            p1.name = "Salah Bedeiwi";
            string name_filter = p1.name.Trim();
            //set & filter address
            p1.address = "361 81st Ave Spring Lake Park MN 55432";
            string address_filer = p1.address.Replace("\n", "").Trim();
            //set & filter phone 
            p1.phone = "612 644 1634";
            p1.phone.Trim(); //trim spaces on right and left
            Regex filerPhone = new Regex(@"^\d{3}(\s|[-])\d{3}(\s|[-])\d{4}$");
            if ( filerPhone.IsMatch(p1.phone) ){
                //if phone matches the 612 644 1634 or 612-644-1634
                p1.phone = p1.phone;
            }else
            {
                p1.phone = "Error:Phone Format was not accepted";
            }
            p1.PrintPersonData();
        }
        static void p2()
        {
            //create person 1
            Person p1 = new Person();
            //set & filter name
            p1.name = "Salah Bedeiwi";
            string name_filter = p1.name.Trim();
            //set & filter address
            p1.address = "361 81st Ave Spring Lake Park MN 55432";
            string address_filer = p1.address.Replace("\n", "").Trim();
            //set & filter phone 
            p1.phone = "6126441634"; //wrong format, so show error msg
            p1.phone.Trim(); //trim spaces on right and left
            Regex filerPhone = new Regex(@"^\d{3}(\s|[-])\d{3}(\s|[-])\d{4}$");
            if (filerPhone.IsMatch(p1.phone))
            {
                //if phone matches the 612 644 1634 or 612-644-1634
                p1.phone = p1.phone;
            }
            else
            {
                //show error msg
                p1.phone = "Error:Phone Format was not accepted";
            }
            p1.PrintPersonData();
        }
        static void p3()
        {
            //create person 1
            Person p1 = new Person();
            //set & filter name
            p1.name = "Salah Bedeiwi";
            string name_filter = p1.name.Trim();
            //set & filter address
            p1.address = "361 81st Ave Spring Lake Park MN 55432";
            string address_filer = p1.address.Replace("\n", "").Trim();
            //set & filter phone 
            p1.phone = "612-644-1634"; //wrong format, so show error msg
            p1.phone.Trim(); //trim spaces on right and left
            Regex filerPhone = new Regex(@"^\d{3}(\s|[-])\d{3}(\s|[-])\d{4}$");
            if (filerPhone.IsMatch(p1.phone))
            {
                //if phone matches the 612 644 1634 or 612-644-1634
                p1.phone = p1.phone;
            }
            else
            {
                //show error msg
                p1.phone = "Error:Phone Format was not accepted";
            }
            p1.PrintPersonData();
        }
        //customer info: note customer has inherited from Person
        static void customer1()
        {
            Customer c1 = new Customer();
            c1.name = "Salah Bedeiwi";
            c1.phone = "   612 644 1634           ".Trim();
            c1.address = "361 81st ave\n Spring Lake Park, MN 55432";
            string address_filer = c1.address.Replace("\n","\t").Trim();
            //filter it & store results on c1.address
            Regex filerPhone = new Regex(@"^\d{3}(\s|[-])\d{3}(\s|[-])\d{4}$");
            if (filerPhone.IsMatch(c1.phone))
            {
                //if phone matches the 612 644 1634 or 612-644-1634
                c1.phone = c1.phone;
            }
            else
            {
                //show error msg
                c1.phone = "Error:Phone Format was not accepted";
            }
            //set shipping address
            c1.PrintPersonData();
            c1.shippingAddress = "361 81st";
            c1.ShipmentAddress();
        }
        //create a new line
        static void newLine()
        {
            Console.WriteLine("\n========================\n");
        }
        //employee
        static void Employee1()
        {
            Employee e1 = new Employee();
            e1.name = "Salamah";
            e1.phone = "000-000-0000";
            e1.address = "000 0's St N, Spring Lake Park MN";
            e1.job = "Engineering";
            e1.PrintPersonData();
            e1.EmployeeJobTitle();
           
        }

        static void Main(string[] args)
        {
            p1(); //print person 1
            newLine();
            p2(); //print person 2
            newLine();
            p3(); //print person 3
            newLine();
            customer1();//print first customer info
            newLine();
            Employee1(); //print employee 1
            newLine();
            Console.ReadKey();
        }
    }
}
