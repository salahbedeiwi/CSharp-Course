using System;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //sub string
            string name = "Salah Bedeiwi";
            Console.WriteLine("my name is {0}", name);
            Console.WriteLine("my name is {0}", name.ToUpper());
            Console.WriteLine("does my name contain salah? => {0}"
                                        , name.Contains("Salah"));
            Console.WriteLine("===================");
            //strat at  2nd letter
            string subName = name.Substring(2);//lah Bedeiwi
            //strat at  3rd letter and print 4 letters
            string subName_2 = name.Substring(3,5);// lah B =>space count
            //strat at 1st letter and print 7 letters
            string subName_3 = name.Substring(1,7);// alah Be =>space count
            Console.WriteLine("my name is => {0}", name);
            Console.WriteLine("strat at 2nd index(3rd letter) => {0}", subName);
            Console.WriteLine("strat at 3rd index(4th letter) and print 5 letters => {0}"
                                                    , subName_2);
            Console.WriteLine("strat at 1st index(2nd letter) and print 7 letters => {0}"
                                                    , subName_3);
            Console.WriteLine("===================");
            Console.Write("Enter file name? => ");
            string fileNameIs = Console.ReadLine();
            //cut the file name from the file extension
            string fileNameWithNoExtension = "";

            Console.WriteLine("Whole File Name and Extension is => {0}", fileNameIs);
            //cut last 4 letters: salahbedeiwiFile.pdf => salahbedeiwiFile
            if(fileNameIs.Length > 4) 
            {
                //just make sure the file has a name more than 4 digits > .pdf
                // cut last four
                fileNameWithNoExtension = fileNameIs.Substring(0, fileNameIs.Length-4);
                Console.WriteLine("File Name Only is => {0}", fileNameWithNoExtension);
            }
            Console.WriteLine("===================");
            Console.ReadKey(); //to avoid pressing ctrl+f5, only press f5

        }
    }
}
