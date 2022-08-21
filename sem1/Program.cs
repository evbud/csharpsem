//Напишите программу, которая на вход
//принимает число и выдаёт его квадрат (число
//умноженное на само себя).
//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int valve = number * number;

// System.Console.WriteLine("Квадрат числа: "+valve);

// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine("Является ли первое число квадратом второго?");
// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if( firstNumber == (secondNumber * secondNumber) )
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
//--- SWITCH
// Console.WriteLine("Введите число от 1 до 7: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 1 && number <= 7)
// {
// switch(number)
// {
// case 1: System.Console.WriteLine("Monday"); break;
// case 2: System.Console.WriteLine("Tuesday"); break;
// case 3: System.Console.WriteLine("Wednesday"); break;
// default: System.Console.WriteLine("Bad num"); break;
// }
// }
// else
// {
// System.Console.WriteLine("Bad number");
// }

//-----SWITCH

// if (number == 1) {
//     Console.WriteLine("понедельник");
// }
// else if (number == 2) {
//     Console.WriteLine("вторник");
// }
// else if (number == 3) {
//     Console.WriteLine("среда");
// }
// else if (number == 4) {
//     Console.WriteLine("четверг");
// }
// else if (number == 5) {
//     Console.WriteLine("пятница");
// }
// else if (number == 6) {
//     Console.WriteLine("суббота");
// }
// else if (number == 7) {
//     Console.WriteLine("воскресенье");
// }
// else {
//     Console.WriteLine("что-то не то ввели");
// }


// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// // 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number2 = -number; //int number2 = number * (-1);
// while (number2 <= number) {
// //---------Console.Write($"{number2},");
// Console.Write(number2+ ",");
// number2++;
// }

//  Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// // 918 -> 8

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if((number / 100 > 0) && (number / 1000) < 1) {
// int lastNumber = number % 10;
// Console.WriteLine("Last Number : "+ lastNumber);
// }
// else {
//     Console.WriteLine("Bad Number");
// }

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// int max = firstNumber;
// int min = secondNumber;

// if(secondNumber > firstNumber)
// {
//     max = secondNumber; min = firstNumber;
// }
// Console.WriteLine("Большее число: "+max + " Меньшее число: "+min);

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber > secondNumber) {
//     System.Console.WriteLine("Большее число: "+ firstNumber+ " Меньшее число: "+secondNumber);
// }
// else if (secondNumber > firstNumber) {
//     System.Console.WriteLine("Большее число: "+ secondNumber+ " Меньшее число: "+firstNumber);
// }
// else {
//     System.Console.WriteLine("Введённые числа равны");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// int max = firstNumber;
// if(secondNumber > max) max = secondNumber;
// if(thirdNumber > max) max = thirdNumber;

// Console.WriteLine("Максимальное число: "+max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int mod = number % 2;
// if (mod == 0) Console.WriteLine("Введённое число является чётным");
// else Console.WriteLine("Введённое число является нечётным");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 2;
if (number >= 2)
{
    while (number2 <= number) {
        Console.Write($"{number2}, ");
        number2 = number2 + 2;
    }
}
else {
    Console.WriteLine("Попробуйте другое число, перезапустите программу");
}