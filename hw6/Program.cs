// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void FindSumPositive()
{
Console.WriteLine("Введите числа через запятую:");
string m = Console.ReadLine();

string[] array = m.Split(',');

int sumPos = 0;

for (int i = 0; i < array.Length; i++)
{
    if (int.Parse(array[i]) > 0) sumPos++;
}

System.Console.WriteLine($"Количество введенных положительных чисел: {sumPos}");
}

FindSumPositive();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindIntersectionPoint()
{
    Console.WriteLine("Введите значение b1: ");
    double b1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение k1: ");
    double k1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение b2: ");
    double b2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение k2: ");
    double k2 = double.Parse(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.Write($"({x}; {y})");
}

FindIntersectionPoint();