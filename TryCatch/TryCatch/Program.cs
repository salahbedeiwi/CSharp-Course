using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            -> try catch ->
            try
            {
                //my own statement(s)

            }
            catch (ExceptionTypeOne ex1)
            {
                //codes 
            }
            catch (ExceptionTypeTwo ex2)
            {
                //codes 
             }
            catch (ExceptionTypeAThree ex3)
            {
                //codes 

            }
             
        */
            try {
                int num1 = 55,
                    num2 = 10,
                    r = num1/num2; //note i can't divide by 0

                Console.WriteLine(r); // System.DivideByZeroException: Attempted to divide by zero.
                //note if any error happens above: none of the below lines will be executed
                string strName = "Salah";
                string[] names = new string[2];
                names[2] = "Mohsin"; //note this is out of range, i only have 2 indexes
                //use : IndexOutOfRangeException
                int namesSize = names.Length;
            }
            //if any of the try block is divided by 0
            catch (DivideByZeroException solveResult)
            {
                //tell him the result:
                Console.WriteLine(solveResult.Message);  //show error message! 
                Console.WriteLine("Please don't divide by 0");  //my own message! 
            }
            //use this incase of my index is out of range
            catch (IndexOutOfRangeException solveResult)
            {
                //if out of index range:
                Console.WriteLine(solveResult.Message);  //show error message! 
                Console.WriteLine("Please make sure you are in the index size");  //my own message! 
            }
            //any errors happens:
            catch (Exception resolveProblem)
            {
                Console.WriteLine(resolveProblem.Message);  //show error message!
            }
            //in case try or catch block is executed, run finally code
            finally
            {
                //in case my try code works:

                Console.WriteLine("======End====");
                //in case my catch is executed
            }
        }
    }
}
