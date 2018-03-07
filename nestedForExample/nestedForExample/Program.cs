using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedForExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            for (int dept = 1; dept <= 4; dept++)
            {
                //4 department
                Console.WriteLine("Department #{0}", dept);
                Console.WriteLine("_________________________________________");
                //for every department, it has a spcific number of employee
                for(int emp = 1; emp <= 3; emp++)
                {
                    Console.WriteLine("\tEmployee {0}", emp);
                }
                Console.WriteLine("*****************************************");
            }
            Console.WriteLine("=============================================");
            for (int comp = 1; comp <= 2; comp++)
            {
                //4 companies
                Console.WriteLine("Company #{0}", comp);
                Console.WriteLine("*****************************************");
                //for every company, it has a spcific number of department
                for (int dept = 1; dept <= 4; dept++)
                {
                    //4 department
                    Console.WriteLine("\tDepartment #{0}", dept);
                    //for every department, it has a spcific number of employee
                    for (int emp = 1; emp <= 3; emp++)
                    {
                        Console.WriteLine("\t\tEmployee {0}", emp);
                    }
                    Console.WriteLine("---------------------------------");
                }
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("=============================================");
        }
    }
}
