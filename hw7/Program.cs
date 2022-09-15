// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] realArray = GetRealArray(m, n, -10, 10);
PrintArrayReal(realArray);

double[,] GetRealArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 1);
        }
    }
    return result;
}

void PrintArrayReal(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


PrintRandomArrayAndFindEl();

void PrintRandomArrayAndFindEl()
{
    int rows = new Random().Next(2, 10);
    int columns = new Random().Next(2, 10);

    Console.WriteLine();

    int[,] randArr = GetArray(rows, columns, 0, 9);

    Console.WriteLine("Задан случайный двумерный массив:\n");
    PrintArray(randArr);
    Console.WriteLine();

    Console.WriteLine("Введите индекс строки искомого элемента: ");
    int iRow = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите индекс столбца искомого элемента: ");
    int iCol = Convert.ToInt32(Console.ReadLine());

    if (iRow < randArr.GetLength(0) && iCol < randArr.GetLength(1))
    {
        Console.WriteLine($"Значение искомого элемента: {randArr[iRow, iCol]}");
    }
    else Console.WriteLine("Такого числа нет в массиве");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


void FindAverageCol()
{
    int[,] intArr = GetArray(new Random().Next(2, 10), new Random().Next(2, 10), 0, 9);
    
    Console.WriteLine();
    Console.WriteLine("Задан случайный массив: ");
    PrintArray(intArr);

    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    float sum = 0;
    for (int i = 0; i < intArr.GetLength(1); i++)
    {
        for (int j = 0; j < intArr.GetLength(0); j++)
        {
            sum += intArr[j, i];
        }
        Console.Write($"{Math.Round((sum/intArr.GetLength(0)), 1)}, ");
        sum = 0;
    }   
}

FindAverageCol();