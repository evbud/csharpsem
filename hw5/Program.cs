// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountEven(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

int[] array = FillArray(4, 100, 1000);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {CountEven(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int SumOdd(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sumOdd += array[i];
    }
    return sumOdd;
}

int[] array1 = FillArray(5, -99, 100);
PrintArray(array1);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {SumOdd(array1)}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array2 = FillArray(7, 1, 10);
PrintArray(array2);
Console.WriteLine();

int n = 0, j = array2.Length - 1;
while (n < (array2.Length / 2))
{ 
    Console.Write($"{array2[n] * array2[j]} ");
    n++;
    j--;
}
if ((array2.Length % 2) != 0)
{
    Console.Write(array2[(array2.Length / 2)]);
}
Console.WriteLine();


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayReal(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(0, 100), 1);
    }
    return array;
}

void PrintArrayReal(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double MaxMinDiff(double[] array)
{
    double numMin = array[0];
    double numMax = array[1];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < numMin)
        {
            numMin = array[i];
        }
        else if (array[i] > numMax)
        {
            numMax = array[i];
        }
    }
    double diffMinMax = numMax - numMin;
    return diffMinMax;
}

double[] arrayReal = FillArrayReal(5);
PrintArrayReal(arrayReal);
Console.WriteLine();

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {MaxMinDiff(arrayReal)}");