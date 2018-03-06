using System;

namespace CalculateNameSpace
{
    class Calculate
    {
        double sum, firstNum, secondNum;

        //add two numbers method:
        double addTwoNum()
        {
            sum = firstNum + secondNum;
            return sum;
        }
        //subtract two numbers method:
        double subTwoNum()
        {
            sum = firstNum - secondNum;
            return sum;
        }
        //multiply two numbers method:
        double multiplyTwoNum()
        {
            sum = firstNum * secondNum;
            return sum;
        }
        //divide two numbers method:
        double divideTwoNum()
        {
            try
            {
                if (firstNum == 0 || secondNum == 0)
                {

                    sum = 0;
                    return 0;
                }
                else
                {
                    sum = firstNum / secondNum;
                    return sum;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                sum = 0;
                return sum;
            }
        }
        //Make it as constructor
        public Calculate()
        {
            Console.WriteLine("Choose any of the methods to start calculation\n"
                                + "(add,num1, num2), (multiply,num1, num2)," +
                                " (divide,num1, num2), (subtract,num1, num2)");
        }
        public Calculate(string calcType, double number1, double number2)
        {
            this.firstNum = number1;
            this.secondNum = number2;
            Console.WriteLine("===================================================================");
            //if type is divide
            switch (calcType)
            {
                case "divide":
                    Console.WriteLine("Result of division is \n\t\t\t\t=> {0}/{1} = {2:f2}", number1, number2, divideTwoNum());
                    break;
                case "add":
                    Console.WriteLine("Result of addition is \n\t\t\t\t=> {0}+{1} = {2:f2}", number1, number2, addTwoNum());
                    break;
                case "multiply":
                case "times":
                    Console.WriteLine("Result of multiplications is \n\t\t\t\t=> {0}*{1:f2} = {2}", number1, number2, multiplyTwoNum());
                    break;
                case "subtract":
                    Console.WriteLine("Result of subtraction is \n\t\t\t\t=> {0}-{1} = {2:f2}", number1, number2, subTwoNum());
                    break;
                default:
                    Console.WriteLine("Must Choose calculation type (add, multiply/times, subtract, divide)");
                    break;
            }
            Console.WriteLine("===================================================================");
        }
        //calculate two int[] together:
        public Calculate(int arrayElements, int[] intArrayOne, int[] intArrayTwo)
        {
            Console.WriteLine("\n==========================================");
            //create an array to save my info on it:
            try { 
                if(intArrayOne.Length != intArrayTwo.Length)
                {
                    Console.WriteLine("Note, your int two arrays are not equal!");
                }else
                {
                    int[] sumOfTwoArray = new int[arrayElements]; //How many array elements I have!
                    //initial first value of the sum array
                    int arrOne = 0;
                    foreach (int arr1Val in intArrayOne)
                    {
                        sumOfTwoArray[arrOne] += arr1Val; //add these values to the array
                        //now do the same thing, but sum up both arrays
                        arrOne += 1;
                    }
                    arrOne = 0;
                    foreach (int arr2Val in intArrayTwo)
                    {
                        sumOfTwoArray[arrOne] += arr2Val; //add the value of array 2 to array 1 as a sum
                        arrOne += 1; //add one to the arrOne, so increments to the next index
                    }
                    Console.WriteLine("\n===Calc Sum of Two Int Array==================");
                    foreach (int s in sumOfTwoArray)
                    {
                        Console.Write(s + ", ");
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Sorry, your elements doesn't match => {0}", e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("You must pass all arguments in thuis method => {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, your elements doesn't match => {0}", e.Message);
            }
            Console.WriteLine("\n==========================================");
        }
    }
}
/*
                 Info of how to use above class:
    Calculate calc = new Calculate();
    Calculate addNum = new Calculate("add", 15,25);
    Calculate multiply = new Calculate("multiply", 15,25);
    Calculate multiply_2 = new Calculate("times", 15,25);
    Calculate divide = new Calculate("divide", 24,36);
    Calculate subtract = new Calculate("subtract", 15,25);
    Calculate somethingWrong = new Calculate("", 15,25);
*/
/* Add this to calculate two int array together:
 * //show two int arrays are added together:
    public static void addTwoIntArrayTogether()
    {
        int[] r1 = new int[] { 1, 2, 3, 4, 5 };
        int[] r2 = new int[] { 1, 2, 3, 4, 5 };
        Calculate calcSumOfTwoArrays = new Calculate(5, r1, r2);

    }
  //then execute this on the main method
  addTwoIntArrayTogether();
 */
