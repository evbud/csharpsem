// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"


string NatVal(int M, int N)
{
    if (N == M) return Convert.ToString(M);
    else return M + ", " + NatVal(M + 1, N);
}

int CheckPositiveInt(string action)
{
    int value;
    while (true)
    {
        Console.WriteLine(action);
        if (int.TryParse(Console.ReadLine(), out value) && value > 0)
        return value;
        else
        {
            Console.WriteLine("Неверный ввод! Попробуйте ввести число больше 0");
        }
    }
}

int numM = CheckPositiveInt("Задайте значение M");
int numN = CheckPositiveInt("Задайте значение N");

Console.WriteLine($"Натуральные числа от {numM} до {numN}: {NatVal(numM, numN)}");


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNatVal(int M, int N)
{
    if (N == M) return N;
    else return M + SumNatVal(M+1, N);
}
Console.WriteLine($"Сумма натуральных элементов от {numM} до {numN}: {SumNatVal(numM, numN)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите первое неотрицательное число: ");
int numMakk = int.Parse(Console.ReadLine());
Console.WriteLine("Ввведите второе неотрицательное число: ");
int numNakk = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для заданных чисел: {Akkerman(numMakk, numNakk)}");