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