// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Cумма цифр = {GetSumNums(num)}");

int GetSumNums(int number)
{
    int result = 0;

    for (int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
}
/*конец*/

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {GetCountNums(num)}");


int GetCountNums(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

// Console.WriteLine("Enter number: ");
// int number = int.Parse(Console.ReadLine());
// int i = 0;
// while (number > 1)
// {
//     number = number/10;
//     i++;
// }
// System.Console.WriteLine(i);

/*конец*/

// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
/*конец*/

// Console.WriteLine("Enter number: ");
// int num = int.Parse(Console.ReadLine());
// int i = 1;
// int f = 1;

// while (i <= num)
// {
//     f = f * i;
//     i++;
// }

// Console.WriteLine(f);

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}
/*конец*/

// int[] array = new int[8];

// for (int i = 0; i < 8; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     // Console.Write($"{array[i]} ");
//     Console.Write(string.Join(" ", array[i]+" "));
// }

// //Console.WriteLine(string.Join(" ", arr))