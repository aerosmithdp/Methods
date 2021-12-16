using System;
using System.Text;
using MethodsForMain;

namespace Methods
{
    class Program
    {
        public static Encoding UTF8 { get; }
        static void Main(string[] args)
        {
            int userСhoice;
            do
            {
                Console.WriteLine("\nMake your choice (1-5)");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Book of names");
                Console.WriteLine("3. Math calculations");
                Console.WriteLine("4. Figures output");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: "); 

                userСhoice = CheckNumber.CheckInt(Console.ReadLine());

                switch (userСhoice)
                {
                    case 1:
                        Console.WriteLine("");
                        Calculator.Calc(1, 2, "+");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Book_of_names.BookAction();
                        break;
                    case 3:
                        Console.WriteLine("");
                        Math_calculations.MathCalculations(5);
                        break;
                    case 4:
                        Console.WriteLine("");
                        Figure_output.Figures(5);
                        break;
                }
            } while (userСhoice != 5);
        }
    }
}
