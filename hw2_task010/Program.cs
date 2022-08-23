//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter 3-digit number: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine($"The second digit in your number: {((number % 100) / 10)}");
}
else
{
    Console.WriteLine("Bad number");
}