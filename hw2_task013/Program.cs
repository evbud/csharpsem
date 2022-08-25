// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// // int 

// System.Console.WriteLine("Enter number: ");
// int number = int.Parse(Console.ReadLine());

// if (number > 99) 
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     int num = number % 10;
//     System.Console.WriteLine(num);
// }
// else 
// {
//     System.Console.WriteLine("There is no third digit");
// }

//string 

System.Console.WriteLine("Enter number: ");
string number = Console.ReadLine();

if (number.Length < 3)
{
    Console.WriteLine("There is no third digit");
}
else
{
    Console.WriteLine(number[2]);
}