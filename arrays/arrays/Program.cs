using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE string[] args is also an array with args
            // array: group of stored elements
            Console.WriteLine("===============================");
            //create an array:
            string[] strName = {"Salah"};
            string[] strFruits = new string[5]; // now i need a string has 5 elements - 4 indexes
            strFruits[0] = "Mango";
            strFruits[1] = "Banana";
            strFruits[2] = "Apple";
            strFruits[3] = "Carrots";
            strFruits[4] = "Watermelon";
            // strFruits[5] = "Fruit Punch";  error:  because only 4 indexes
            //Unhandled Exception: System.IndexOutOfRangeException: Index was outside the bounds of the array.
            Console.WriteLine(strName[0]);
            //Console.WriteLine(strFruits[5]);//error: 4 indexes only on strFruits
            Console.WriteLine(strFruits[4]);//Watermelon

            Console.WriteLine("===============================");
            int[] studentsGrades = new int[5]; //say we have 5 students
            studentsGrades[0] = 100; // give student 1 grade 100 - 0-index
            studentsGrades[1] = 75; //1-index
            studentsGrades[2] = 10;
            studentsGrades[3] = 36;
            //studentsGrades[3] = int.Parse("150"); //it must be int as the array type
            studentsGrades[4] = 40; //4-index
            int avgGrade = (studentsGrades[0] 
                    + studentsGrades[1] 
                        + studentsGrades[2] 
                            + studentsGrades[3] + studentsGrades[4]) / 5;
            Console.WriteLine("Student #4 Grade: => {0}%", studentsGrades[4]);//40
            Console.WriteLine("Average Grades: => {0}%", avgGrade);//40
            Console.WriteLine("===============================");
            object[] scores = new object[6];
            scores[0] = "Salah"; //name - string
            scores[1] = 29; //age - int
            scores[2] = 5.6; //height - double
            scores[3] = 'i'; //middle name initial - char
            scores[4] = 204.50; //weight in lbs - double
            //cool idea, it does accept any data type.
            Console.WriteLine("weight of {0} is {1} lbs => ", scores[0], scores[4]);//salah, weight
            Console.WriteLine("{0}'s height: => {1} inches", scores[0], scores[2]);//salah, height
            Console.WriteLine("the default value of non-intilized elements on object is => {0}",
                                                                scores[5]);
            //note, we haven't initilized the value for scores[5] and it is an object ""
            Console.WriteLine("===============================");
            string[] str = new string[3];
            //how many elements on the str array
            int arrayStrLength = str.Length;
            Console.WriteLine("Elements in str array: {0}", arrayStrLength);
            Console.WriteLine("===============================");
            Console.Write("Enter an array elements => ");
            int usersArr = int.Parse(Console.ReadLine());
            string[] randArray = new string[usersArr];
            randArray[0] = "Ahmed";
            randArray[randArray.Length - 1] = "Salah"; //one before last one
            //how many elements on the str array
            int StrLength = randArray.Length;
            Console.WriteLine("Users Elements in str array: {0}", StrLength);
            Console.WriteLine("Users Elements #{2} at index #{0} => {1}", 
                                        StrLength-1,
                                            randArray[randArray.Length - 1],
                                                StrLength);
            Console.WriteLine("===============================");
            char[] studentFirstNameInitials = new char[13];
            studentFirstNameInitials[0] = 'S';
            studentFirstNameInitials[1] = 'a';
            studentFirstNameInitials[2] = 'l';
            studentFirstNameInitials[3] = 'a';
            studentFirstNameInitials[4] = 'h';
            studentFirstNameInitials[5] = ' ';
            studentFirstNameInitials[6] = 'B';
            studentFirstNameInitials[7] = 'e';
            studentFirstNameInitials[8] = 'd';
            studentFirstNameInitials[9] = 'e';
            studentFirstNameInitials[10] = 'i';
            studentFirstNameInitials[11] = 'w';
            studentFirstNameInitials[12] = 'i';
            //below one: it gets the type: System.Char[]
            Console.WriteLine("My name is => {0}", studentFirstNameInitials);
            Console.WriteLine(studentFirstNameInitials);// Salah Bedeiwi
            Console.WriteLine(studentFirstNameInitials.Length);// Salah Bedeiwi length: 13
            Console.WriteLine(studentFirstNameInitials[0]+
                                        studentFirstNameInitials[1]+
                                            studentFirstNameInitials[2]);// 288. must use toString()
            //why the number 288, because it did consider the char as byte 
            //and it added its decimal val.
            Console.WriteLine( studentFirstNameInitials[0].ToString() +
                                        studentFirstNameInitials[1].ToString() +
                                            studentFirstNameInitials[2].ToString() );// Sal
            string strNames = studentFirstNameInitials.ToString();
            Console.WriteLine(strNames);//System.Char
            Console.WriteLine("====================================");
            //how to diplay the info
            //add the values of the passed array here
            string strNewName = new string(studentFirstNameInitials);
            Console.WriteLine(strNewName);//Salah Bedeiwi
            Console.WriteLine(strNewName[0]);//S
            Console.WriteLine(strNewName[1]);//a
            Console.WriteLine("====================================");
            //HAVE A STRING AND CONVERT IT TO CHAR
            string strN = "Salah";
            char[] cName;
            cName = strN.ToCharArray();//convert a string to char array
            Console.WriteLine("my char cName => "+cName);//salah
            Console.WriteLine("my char cName index 0  => " + cName[0]); //s
            Console.WriteLine("my char cName length  => " + cName.Length);//5
            Console.WriteLine("====================================");
        }
    }
}
