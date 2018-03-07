using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //for regular expressions

namespace validateName
{
    class Program
    {
        static void Main(string[] args)
        {
            //validate name:
            Regex regUserName;string userName;
            //Console.Write("Enter One number/digit? => ");
            //string userName = Console.ReadLine();
            //Regex regUserName = new Regex(@"^\w$"); //one letter or number
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good job");
            //else Console.WriteLine("Please enter only one number or one letter!");
            //Console.WriteLine("============");
            //Console.Write("Enter more than one number/digit? => ");
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^\w+$"); //one letter/number or more
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good job");
            //else Console.WriteLine("Please enter only one number/letter or more!");
            //Console.WriteLine("============");
            //Console.Write("Enter username? => ");
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^[A-Za-z]+$"); //more than a letter. can't be empty
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good job");
            //else Console.WriteLine("Please enter only letters!");
            //Console.WriteLine("============");
            //Console.Write("Enter small letters for username? => ");
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^[a-z]+$"); //more than a letter. can't be empty
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good job");
            //else Console.WriteLine("Please enter small letters only!");
            //Console.WriteLine("============");
            ////A325aa
            //Console.Write("Enter username \"A325aa\"? => ");
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^[A-Z]\d{3}[a-z]{2}$"); // A325aa
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good job");
            //else Console.WriteLine("Please enter it as A325aa!");
            Console.WriteLine("============");
            //Aa.... 123 =>.... means any small letters
            //Console.Write("Enter username \"Aa..... 123\"? => ");
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^[A-Z][a-z]+\s\d{3}$"); // Aa.....space123
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good job");
            //else Console.WriteLine("Please enter it as Aa..... 123!");
            //Regex reg = new Regex(@"^[a-z]{4}$"); //at least should be 4 letters
            //Console.WriteLine("=====================");//Salah Bedeiwi
            //Console.Write("Enter your first and last name?");
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^[A-Z][a-z]+\s[A-Z][a-z]+$");//Salah Bedeiwi
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good Job");
            //else Console.WriteLine("You must enter your first and last name!");
            //Console.WriteLine("=====================");//Salah Bedeiwi
            //Console.Write("Enter your first or first and last or first, middle, last, ..? ");
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^[A-Z][a-z]+(\s[A-Za-z]+)*$");
            ////Salah Bedeiwi Salah
            ////Salah
            ////Salah Bedeiwi
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good Job");
            //else Console.WriteLine("You must enter your first and last name!");
            //Console.WriteLine("=====================");
            //Console.Write("Enter your nine digits phone ..? "); // 111-111-1212
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^(\d{3}[-]\d{3}[-]\d{4})|(\d{3}\d{3}\d{4})$");
            ////111-111-1212
            ////1111111212
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good Job");
            //else Console.WriteLine("You must enter 9 phone digits!");
            //Console.WriteLine("=====================");
            //Console.Write("Enter your nine digits phone or first and last name..? "); // 111-111-1212
            //userName = Console.ReadLine();
            //regUserName = new Regex(@"^([A-Z][a-z]+(\s[A-Z][a-z])*)|(\d{3}\d{3}\d{4})|(\d{3}[-]\d{3}[-]\d{4})$");
            ////111-111-1212 or Salah
            ////111-111-1212 or Salah Bedeiwi
            ////111-111-1212 or Salah Imad Bedeiwi
            ////1111111212 or Salah,....
            //if (regUserName.IsMatch(userName)) Console.WriteLine("Good Job");
            //else Console.WriteLine("You must enter your first and last name or nine digits!");
            //Console.WriteLine("=====================");
            Console.Write("Enter your email..? "); // 111-111-1212
            userName = Console.ReadLine();
            //1st way
            //regUserName = new Regex(@"^([A-Za-z0-9_-.]+)\@([A-Za-z0-9-]+)(\.)([A-Za-z]{2,5})$");
            //2nd way
            regUserName = new Regex(@"^([A-Za-z0-9])+\@([A-Za-z0-9]+)(\.)([A-Za-z0-9]+)$");
            regUserName = new Regex(@"^\w+([-_.]\w+)*\@\w+([-_.]\w+)*(\.)(\w+([-_.]\w+)*)$");
            //bedei@umn.edu, Bedei2121@umn.edu
            //salah.bedeiwi_lkasd-123sa@gmail_23lk.com.com
            if (regUserName.IsMatch(userName)) Console.WriteLine("Good Email");
            else Console.WriteLine("Enter an email as salah2322@umn.edu");

        }

    }
}
