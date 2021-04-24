using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Some()
        {
            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = height; j > i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Some();
            Console.WriteLine();
            Some();
            Console.WriteLine();
            Some();
            Console.WriteLine();
        }
    }
}
