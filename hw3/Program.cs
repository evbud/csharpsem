using System;

namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 19: Напишите программу, которая принимает на
            // вход пятизначное число и проверяет, является ли оно
            // палиндромом.
            PalindromeCheck();

            // Задача 21: Напишите программу, которая принимает на
            // вход координаты двух точек и находит расстояние между
            // ними в 3D пространстве.
            Distance3D();

            // Задача 23: Напишите программу, которая принимает на
            // вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            NumberCubed();
        }

        // Задача 19: Напишите программу, которая принимает на
        // вход пятизначное число и проверяет, является ли оно
        // палиндромом.
        // 14212 -> нет
        // 23432 -> да
        // 12821 -> да
        
        static void PalindromeCheck()
        {
            System.Console.Write("Enter 5-digit number to check if it palindrome or not: : ");
            string num = Console.ReadLine();
            if (num.Length == 5)
            {
                if (num[0] == num[4] && num[1] == num[3])
                {
                    System.Console.WriteLine("yes");
                }
                else
                {
                    System.Console.WriteLine("no");
                }
            }
            else
            {
                System.Console.WriteLine("Bad number");
            }
        }

        //Задача 21: Напишите программу, которая принимает на
        //вход координаты двух точек и находит расстояние между
        //ними в 3D пространстве.
        // A (3,6,8); B (2,1,-7), -> 15.84
        // A (7,-5, 0); B (1,-1,9) -> 11.53

        static void Distance3D()
        {
            System.Console.WriteLine("Enter x1: ");
            int x1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter y1: ");
            int y1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter z1: ");
            int z1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter x2: ");
            int x2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter y2: ");
            int y2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter z2: ");
            int z2 = int.Parse(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

            System.Console.WriteLine($"Distance between points: {result:f2}");
        }

        // Задача 23: Напишите программу, которая принимает на
        // вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        // 3 -> 1, 8, 27
        // 5 -> 1, 8, 27, 64, 125

        static void NumberCubed()
        {
            System.Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                System.Console.Write($"{Math.Pow(i, 3)}, ");
            }
        }
    }
}