// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void NumberPowered()
{
    Console.WriteLine("Enter first number: ");
    int firstNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter second number: ");
    int secondNumber = int.Parse(Console.ReadLine());

    int powNumber = firstNumber;

    for (int i = 1; i < secondNumber; i++)
    {
        powNumber = powNumber * firstNumber;
    }

    Console.WriteLine($"First number raised to the power of second: {powNumber}");
}

NumberPowered();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант с while

void SumDigWhile()
{
    Console.WriteLine("Enter number: ");
    int number = int.Parse(Console.ReadLine());

    int sum = 0;

    while (number >= 1)
    {
        sum += (number % 10);
        number /= 10;
    }

    Console.WriteLine($"Sum of number's digits: {sum}");
}

SumDigWhile();

// Вариант с for

void SumDigFor()
{
    Console.Write("Enter number: ");

    int sum = 0;

    for (int number = int.Parse(Console.ReadLine()); number >= 1; number /= 10)
    {
        sum += (number % 10);
    }

    Console.WriteLine($"Sum of number's digits: {sum}");
}

SumDigFor();

// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив 
// рандоными данными от минимального до максимального значение .И важное уточнениее , делать все в методе 
// который возвращает массив

void FillUsersRandomArray()
{
    Console.WriteLine("Enter array size: ");
    int size = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter min value: ");
    int min = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter max value: ");
    int max = int.Parse(Console.ReadLine());

    int[] array = new int[size];

    void FillArray(int[] array)
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max + 1);
            // Console.Write($"{array[i]} ");
            Console.Write(String.Join(" ", array[i] + " "));
        }
        Console.WriteLine();
    }

    FillArray(array);
}

FillUsersRandomArray();