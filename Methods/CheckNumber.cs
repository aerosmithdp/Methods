using System;


namespace MethodsForMain
{
    class CheckNumber
    {
        public static int CheckInt(string stringCheck)
        {
            int intCheck;
            while (!int.TryParse(stringCheck, out intCheck))
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter a number!");
                stringCheck = Console.ReadLine();
            }
            return intCheck;
        }
        public static double CheckDouble(string stringCheck)
        {
            double doubleCheck;
            while (!double.TryParse(stringCheck, out doubleCheck))
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter a number");
                stringCheck = Console.ReadLine();
            }
            return doubleCheck;
        }
    }
}
