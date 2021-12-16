using System;


namespace MethodsForMain
{
    class Math_calculations
    {
        public static double MathCalculations(double x)
        {
            double answer = 0;
            Console.WriteLine("Make your choice(1-4)");
            Console.WriteLine("1. Calculate perimeter");
            Console.WriteLine("2. Calculate area");
            Console.WriteLine("3. Calculate the radius of a circle");
            Console.WriteLine("4. Exit");
            Console.Write("Make your choice(1-4): ");

            int userChoice = CheckNumber.CheckInt(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Perimeter();
                    return answer;
                case 2:
                    Area();
                    return answer;
                case 3:
                    Radius();
                    return answer;
            }
            return answer;
        }
        private static void Perimeter()
        {
            Console.WriteLine("\n");
            Console.WriteLine("All calculations are made in meters");
            Console.Write("Enter a value for the radius: ");
            double radius = CheckNumber.CheckDouble(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            Console.WriteLine($"Perimeter is: {perimeter}");
        }
        private static void Area()
        {
            Console.WriteLine("\n");
            Console.WriteLine("All calculations are made in meters ");
            Console.Write("Enter a value for the radius: ");
            double radius = CheckNumber.CheckDouble(Console.ReadLine());
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"Area is: {area}");
        }
        private static void Radius()
        {
            Console.WriteLine("\n");
            Console.WriteLine("All calculations are made in meters ");
            Console.Write("Enter a value for the diameter: ");
            double diameter = CheckNumber.CheckDouble(Console.ReadLine());
            double radius = diameter / 2;
            Console.WriteLine($"Radius is: {radius}");
        }
    }
}
