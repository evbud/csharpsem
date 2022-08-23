// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter number of the day of the week: ");
int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    switch(number)
{
    case 6 : 
    case 7 : 
        Console.WriteLine("Yes"); 
    break;
    default: 
        Console.WriteLine("No"); 
    break;
}
}
else
{
    Console.WriteLine("Bad number");
}