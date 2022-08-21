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

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) {
    System.Console.WriteLine("Большее число: "+ firstNumber+ " Меньшее число: "+secondNumber);
}
else if (secondNumber > firstNumber) {
    System.Console.WriteLine("Большее число: "+ secondNumber+ " Меньшее число: "+firstNumber);
}
else {
    System.Console.WriteLine("Введённые числа равны");
}