using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // print date and time
            Console.WriteLine("===============================");
            string strDateTime;
            // 2/22/2018 02:25:26 PM
            strDateTime = DateTime.Now.ToString();
            Console.WriteLine("Todays Date: {0}", strDateTime);
            // 2/22/2018 02:25:26 PM
            Console.WriteLine("Todays Date: {0}", DateTime.Now);
            // Add specific time:
            //make it type datetime, so I can use it later as DateTime
            DateTime pickDate = Convert.ToDateTime("02/26/2018");
            DateTime pickDateAndTime = Convert.ToDateTime("02/26/2018 05:15:36 PM");

            Console.WriteLine("picked date 02/26/2018 as => {0}", pickDate);
            Console.WriteLine("picked date 02/26/2018 as => {0}", pickDateAndTime);
            Console.WriteLine("===============================");
            //custom date:
            string todaysDate = DateTime.Now.ToString();//2/22/2018 02:25:26 PM
            string customTodaysDate = DateTime.Now.ToString("d"); //4/4/2017
            string customTodaysDate_1 = DateTime.Now.ToString("D"); //Thursday, February 22, 2018
            string customTodaysDate_2 = DateTime.Now.ToString("t"); //07:52 PM
            string customTodaysDate_3 = DateTime.Now.ToString("T"); // 11:49:34 PM

            Console.WriteLine("Default todays's date => "+todaysDate);
            Console.WriteLine("Custom todays's date => " + customTodaysDate); 
            Console.WriteLine("Custom todays's date => " + customTodaysDate_1);
            Console.WriteLine("Custom todays's time => " + customTodaysDate_2);
            Console.WriteLine("Custom todays's time => " + customTodaysDate_3);
            
            //format date as I like!
            string customTodaysDate_4 = DateTime.Now.ToString("dd"); // 22 -> only day
            string customTodaysDate_5 = DateTime.Now.ToString("MM"); // 02 -> only month
            string customTodaysDate_6 = DateTime.Now.ToString("yyyy"); // 2018 -> only year
            string customTodaysDate_7 = DateTime.Now.ToString("yy"); // 18 -> only year small
            string customTodaysDate_8 = DateTime.Now.ToString("M"); // February 22
            string customTodaysDate_9 = DateTime.Now.ToString("y"); // February 2018 
            string customTodaysDate_10 = DateTime.Now.ToString("d"); // 2/22/2018

            Console.WriteLine("=====================================================");
            Console.WriteLine("today day only => " + customTodaysDate_4);
            Console.WriteLine("today month only => " + customTodaysDate_5);
            Console.WriteLine("today year as yyyy => " + customTodaysDate_6);
            Console.WriteLine("today year as yy => " + customTodaysDate_7);
            Console.WriteLine("today month and day as Month, day => " + customTodaysDate_8);
            Console.WriteLine("today month and year as Month, year => " + customTodaysDate_9);
            Console.WriteLine("today month and year as Month, year => " + customTodaysDate_10);
            Console.WriteLine("=====================================================");
            Console.WriteLine("=====Custom Date as I like===========================");
            //string custDate = DateTime.Now.ToString("dd/MM/yyyy"); //23/02/2018
            //string custDate = DateTime.Now.ToString("dd/MM/yy"); //23/02/18
            //string custDate = DateTime.Now.ToString("dd-MM-yy"); //23-02-18
            string custDate = DateTime.Now.ToString("d/M/yyyy"); //23/2/2018
            Console.WriteLine("Print date as => {0}", custDate);
            string custTimeHr = DateTime.Now.ToString("hh"); //hours only -> 12
            Console.WriteLine("Print current hour as => {0}", custTimeHr);
            string custTimeMinutes = DateTime.Now.ToString("mm"); //minutes only -> 06
            Console.WriteLine("Print current minutes as => {0}", custTimeMinutes);
            string custTimeSeconds = DateTime.Now.ToString("ss"); //seconds only -> 06
            Console.WriteLine("Print current seconds as => {0}", custTimeSeconds);
            string custTimeSMorningOrEvening = DateTime.Now.ToString("tt"); //AM/PM
            Console.WriteLine("Print current AM/PM as => {0}", custTimeSMorningOrEvening);
            //print all time
            string currentTime = DateTime.Now.ToString("hh:mm:ss tt"); // 12:10:55 AM
            Console.WriteLine("Print current time => {0}", currentTime);

            //print all date and time
            string currentDateAndTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"); //23-02-2018 12:12:30 AM
            Console.WriteLine("Print current date and time => {0}", currentDateAndTime);
            Console.WriteLine(DateTime.Now.Day); //todays day
            Console.WriteLine(DateTime.Now.Month); //todays month
            Console.WriteLine(DateTime.Now.Year); //todays Year
            Console.WriteLine(DateTime.Now.Hour); //todays time Hour in 24 hours format
            Console.WriteLine(DateTime.Now.Minute); //todays time minutes
            Console.WriteLine(DateTime.Now.Millisecond); //todays time seconds
            Console.WriteLine("=====================================================");
            //i can add days, or have an alarm after specific days
            Console.WriteLine(DateTime.Now.AddDays(5));//5 days from today
            Console.WriteLine(DateTime.Now.AddHours(12));//add 12 hours from now: 2/24/2018 6:37:24 AM
            Console.WriteLine(DateTime.Now.AddYears(2));//add two years: 2/24/2020 6:37:24 AM
            Console.WriteLine(DateTime.Now.AddYears(2).AddMonths(2).AddDays(15).AddHours(15));
            //note i could add years and month and days and hours:  5/9/2020 9:39:28 AM
            Console.WriteLine( //note I could format it as well
                            DateTime.Now.AddYears(2).
                                AddMonths(2).AddDays(15).
                                    AddHours(15).
                                        ToString("dd-MM-yy - hh:mm:ss tt")); //09-05-20 - 09:41:04 AM
            // print days name and month name
            Console.WriteLine("=====================================================");
            Console.WriteLine(DateTime.Today); //2/23/2018 12:00:00 AM
            DateTime currentTime1 = Convert.ToDateTime("01/01/2000");
            Console.WriteLine(currentTime1.Month);//1
            for(int x = 1; x <= 12; x++)
            {
                Console.WriteLine(currentTime1.ToString("MMMM")); //GET MONTH NAME
                currentTime1 = currentTime1.AddMonths(1);
            }
            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine(currentTime1.ToString("MMM")); //GET MONTH ABBREVIATED
                currentTime1 = currentTime1.AddMonths(1);
            }
            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine(currentTime1.ToString("MM")); //GET MONTH AS NUMBERS
                currentTime1 = currentTime1.AddMonths(1);
            }

            Console.WriteLine("=====================================================");
            DateTime DayTime = Convert.ToDateTime("2/23/2018");
            //we need to print week days starting from 2/23/2018. 23rd is friday
            for (int x = 1; x <= 7; x++)
            {
                Console.WriteLine(DayTime.ToString("dd")); //GET days as numbers
                DayTime = DayTime.AddDays(1);
            }
            for (int x = 1; x <= 7; x++)
            {
                Console.WriteLine(DayTime.ToString("dddd")); //GET days as whole name
                DayTime = DayTime.AddDays(1);
            }
            for (int x = 1; x <= 7; x++)
            {
                Console.WriteLine(DayTime.ToString("ddd")); //GET days as abbreviated
                DayTime = DayTime.AddDays(1);
            }

            Console.WriteLine("=====================================================");
        }
    }
}
