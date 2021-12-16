using System;
using System.Collections.Generic;


namespace MethodsForMain
{
    class Book_of_names
    {
        public static void BookAction()
        {
            List<string> names = new List<string>();
            string userChoice;
            do
            {
                Console.WriteLine("Make your choice(1-4)");
                Console.WriteLine("1. Enter the name");
                Console.WriteLine("2. Show all names");
                Console.WriteLine("3. Delete the name");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("");
                        Enter_name(names);
                        break;
                    case "2":
                        Console.WriteLine("");
                        All_names(names);
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("");
                        Console.Write("Choose the number of name: ");
                        Delete_name(names, CheckNumber.CheckInt(Console.ReadLine()));
                        Console.WriteLine("");
                        break;
                }
            } while (userChoice != "4");

        }

        private static void Enter_name(List<string> names)
        {
            Console.Write("Enter the name: ");
            names.Add(Console.ReadLine());
        }

        private static void All_names(List<string> names)
        {
            int i = 0;
            foreach (string str in names)
            {
                Console.WriteLine(i + ". " + str);
                i++;
            }
        }

        private static void Delete_name(List<string> names, int number)
        {
            Console.Write("Enter index of deleted number: ");
            names.RemoveAt(number);
        }
    }
}

