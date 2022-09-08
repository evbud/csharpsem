// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// Console.Clear();

// int[] array = GetArray(10, 0, 10);

// System.Console.WriteLine();

// Console.WriteLine("Array " + String.Join(" ", array));
// ReversArray1(array);
// Console.WriteLine("ReversArray1 : " + String.Join(" ", array));

// System.Console.WriteLine();

// Console.WriteLine("Array " + String.Join(" ", array));
// int[] reversArray = ReversArray2(array);
// Console.WriteLine("ReversArray2 : " + String.Join(" ", reversArray));

// System.Console.WriteLine();

// Console.WriteLine("Array " + String.Join(" ", array));
// ReversArray3(array);
// Console.WriteLine("ReversArray3 : " + String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReversArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int numTemp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = numTemp;
//     }
// }

// int[] ReversArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];

//     }
//     return result;
// }

// void ReversArray3(int[] inArray)
// {
//     Array.Reverse(inArray);
// }


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int c = int.Parse(Console.ReadLine());

// if (a < (b + c) && b < (a+c) && c < (a + b))
// {
//     Console.WriteLine("Треугольник с заданными сторонами существует");
// }
// else Console.WriteLine("нет");


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Console.WriteLine("Введите десятичное число: ");
// int number = int.Parse(Console.ReadLine());

// string s = string.Empty;

// while (number > 0)
// {
//     s = Convert.ToString(number % 2) + s;
//     number /= 2;
// }

// Console.WriteLine(s);

//-------//


// Console.WriteLine("Введите десятичное число: ");
// int number=int.Parse(Console.ReadLine());

// string res1=Convert.ToString(number,2);
// string res2=DecToNum(number,2);

// Console.WriteLine($"{number}->{res1}");
// Console.WriteLine($"{number}->{res2}");


//Универсальный математический для перевода из 10 в любую

// string DecToNum(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber/otherSystem;
//         res=nums[decNumber-otherSystem*ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }


//Универсальный математический для перевода из 10 в двоичную


// Console.WriteLine("Введите число: ");

// int num = Convert.ToInt32(Console.ReadLine());

// bool[] array = Num2(num);
// Console.WriteLine(String.Join("", array)); 

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(Convert.ToInt32(array[i]));
// }

// bool[] Num2 (int num)
// {
//     int result = 0;
//     bool[] arr = new bool[32];
//     int i;
//     for (i = 0; num > 0; i++)
//     {
//         result = num%2;
//         num = num/2;
//         arr[arr.Length -1 -i] = Convert.ToBoolean(result);
//     }
//     return arr;
// }


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.WriteLine("Задайте количество первых чисел Фибоначчи для вывода: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int first = 0;
// int second = 1;
// int current = 0;
// Console.Write($"Если N = {n} ->");

// for (int i = 0; i < n; i++)
// {
//     if (i == 0)
//     {
//         // first = 0;
//         Console.Write(" 0");
//     }
//     else if (i == 1)
//     {
//         // second = 1;
//         Console.Write(" 1");
//     }
//     else
//     {
//         current = first + second;
//         first = second;
//         second = current;

//         Console.Write($" {current}");
//     }
// }

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


// int[] FillArray(int size, int min, int max)
// {   
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int[] CopyArray(int[] array)
// {
//     int[] copy = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         copy[i] = array[i];
//     }
//     return copy;
// }

// int[] array = FillArray(5, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int[] copy = CopyArray(array);
// PrintArray(copy);


//=======//======//

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] copyArray=CopyArray(array);
Console.WriteLine(String.Join(" ", copyArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}