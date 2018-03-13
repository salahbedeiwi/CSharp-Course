using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //custom your class data:
            Console.WriteLine("================================================");
            PersonData pd = new PersonData();
            pd.NAME = "Salah Bedeiwi";
            pd.Address = "Minnesota, USA";
            pd.ID = 1;
            pd.PRIZES = Prizes.Bronze_Medal;
            Console.WriteLine("================================================");
            PersonData pd_2 = new PersonData();
            pd_2.NAME = "Ahmed E";
            pd_2.Address = "Minnesota, USA";
            pd_2.ID = 3;
            pd_2.PRIZES = Prizes.Brown_Medal;
            Console.WriteLine("================================================");
            Person p = new Person();
            p.NAME = pd.NAME;
            p.Address = pd.Address;
            p.ID = pd.ID;
            p.PRIZES = pd.PRIZES;
            p.PrintData();
            Console.WriteLine("================================================");
            //shortcut and most fun part:
            p = pd; //means all data are the same - remember implicit class
            p.PrintData();
            Console.WriteLine("================================================");
            Person p2 = new Person();
            p2 = pd_2;
            p2.PrintData();
            Console.WriteLine("================================================");
            //We know how to do the following. Now the question is how to
            Person p0 = new Person();
            p0.NAME = "Mohamed E";
            p0.Address = "Minnesota, USA";
            p0.ID = 7;
            p0.PRIZES = Prizes.Gold_Medal;
            p0.PrintData();
            Console.WriteLine("================================================");

            object[] data_1 = { 218, "Ahmed", "Giza, Egypt", Prizes.Brown_Medal };
            object[] data_2 = { 241, "Mohamed", "Aswan, Egypt", Prizes.Bronze_Medal };
            object[] data_3 = { 101, "Kamel", "Cairo, Egypt", Prizes.Silver_Medal };
            object[] data_4 = { 025, "Sayed", "Alex, Egypt", Prizes.Gold_Medal};
            Person p_obj_1 = new Person();
            Person p_obj_2 = new Person();
            Person p_obj_3 = new Person();
            Person p_obj_4 = new Person();
            Person p_obj_6 = new object[] { 249, "Khalid", "Mansoura, Egypt", Prizes.Brown_Medal};
            p_obj_1 = data_1; p_obj_1.PrintData();
            p_obj_2 = data_2; p_obj_2.PrintData();
            p_obj_3 = data_3; p_obj_3.PrintData();
            p_obj_4 = data_4; p_obj_4.PrintData();
            p_obj_6.PrintData();
            Console.WriteLine("================================================");
            //have some error on the object
            object[] data_5 = { "025", "Sayed", "Alex, Egypt", Prizes.Gold_Medal };
            Person p_obj_5 = new Person();
            p_obj_5 = data_5; p_obj_5.PrintData();
            Console.ReadKey();
        }
    }
}
