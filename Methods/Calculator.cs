using System;


namespace MethodsForMain
{
    public static class Calculator
    {

        public static double Calc(double firstNumber, double secondNumber, string Operator)                   
        {
            string goNext;
            Console.Write("Enter the first number: ");
            firstNumber = CheckNumber.CheckDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNumber = CheckNumber.CheckDouble(Console.ReadLine());
            Console.Write("Select operator(can be '+', '-', '*', '/'): ");
            Operator = Console.ReadLine();
            double temporaryResult = Calculate(firstNumber, secondNumber, Operator);
            int i = 0; i++;
            Console.WriteLine($"Result: {temporaryResult}");
            Console.WriteLine("Go to next action? (y/n)");
            goNext = Console.ReadLine();
            if (goNext == "y")
            {
                if (i != 0)                                                        
                {
                    do
                    {
                        Console.Write("Select operator(can be '+', '-', '*', '/'): ");
                        Operator = Console.ReadLine();
                        Console.Write("Enter number: ");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        temporaryResult = Calculate(temporaryResult, secondNumber, Operator);
                        Console.Write($"Result: {temporaryResult}");
                        Console.WriteLine("\nGo to next action? (y/n)");
                        goNext = Console.ReadLine();
                        Console.Clear();
                    } while (goNext == "y");
                }
                else
                {
                    Console.WriteLine("You have selected the wrong operator");
                }
            }
            return temporaryResult;
        }

        public static double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;

        public static double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;

        public static double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;

        public static double Divide(double firstNumber, double secondNumber) => firstNumber / secondNumber;

        private static double Calculate(double firstNumber, double secondNumber, string Operator)                
        {
            switch (Operator)
            {
                case "+":
                    return Add(firstNumber, secondNumber);
                case "-":
                    return Subtract(firstNumber, secondNumber);
                case "*":
                    return Multiply(firstNumber, secondNumber);
                case "/":
                    return Divide(firstNumber, secondNumber);
                default:
                    return 0;
            }
        }
    }
}
