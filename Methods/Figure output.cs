using System;


namespace MethodsForMain
{
    class Figure_output
    {
        public static double Figures(double x)
        {
            
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Triangle rectangular");
            Console.WriteLine("3. Equilateral triangle");
            Console.WriteLine("4. Inverted triangles");
            Console.WriteLine("5. Hourglass");
            Console.Write("Choose an option: ");

            int userChoice = CheckNumber.CheckInt(Console.ReadLine());
            do
            {
                switch (userChoice)
                {
                    case 1:
                        Square();
                        return userChoice;
                    case 2:
                        Triangle();
                        return userChoice;
                    case 3:
                        EquilateralTriangle();
                        return userChoice;
                    case 4:
                        InvertedTriangle();
                        return userChoice;
                    case 5:
                        HourGlass();
                        return userChoice;
                    case 0:

                        return userChoice;
                }
            } while (true);
        }

        public static void InvertedTriangle()
        {
            string[,] str = new string[5, 5];
            for (int i = 4; i >= 0; i--)                //заполнение диагонали
            {
                for (int j = 4; j >= 0; j--)
                {
                    str[i, j] = "0";

                    if (i == j)
                    {
                        break;
                    }
                }

            }

            for (int i = 0; i < 5; i++)                 //заполнение пустотой
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)                 //вывод массива
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Triangle()
        {
            string[,] str = new string[5, 5];
            for (int i = 0; i <= 4; i++)                //заполнение диагонали
            {
                for (int j = 0; j <= 4; j++)
                {
                    str[i, j] = "0";

                    if (i == j)
                    {
                        break;
                    }
                }

            }

            for (int i = 0; i < 5; i++)                 //заполнение пустотой
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)                 //вывод массива
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Square()
        {
            string[,] str = new string[5, 5];
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    str[i, j] = "0";
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)                 //вывод массива
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void EquilateralTriangle()
        {
            int p = 5;
            int n = p;
            for (int i = 0; i < n; i++, p--)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int m = 0; m < i * 2; m++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
            for (int i = 0; i <= n; i++)
            {
                Console.Write("--");
            }
            Console.ReadKey();
        }
        public static void HourGlass()
        {
            string[,] str = new string[5, 5];
            for (int i = 0; i <= 4; i++)                //заполнение диагонали
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (i == 0)
                    {
                        str[i, j] = "0";
                    }
                    if (i == j)
                    {
                        str[i, 5 - j - 1] = "0";
                        str[i, j] = "0";
                    }
                    if (i == 4)
                    {
                        str[i, j] = "0";
                    }

                }

            }

            for (int i = 0; i < 5; i++)                 //заполнение пустотой
            {
                for (int j = 0; j < 5; j++)
                {
                    if (str[i, j] != "0")
                    {
                        str[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < 5; i++)                 //вывод массива
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(str[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
