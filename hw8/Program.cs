// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void OrderArrayRows(int[,] array)
{
    for (int i = 0; i < (array.GetLength(0)); i++)
    {
        for (int a = array.GetLength(1); a > 1; a--)
        {
            for (int j = 0; j < (array.GetLength(1) - 1); j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }

        }
    }
}

int m = 5, n = 5;
int[,] array54 = FillArray(m, n, 1, 9);
PrintArray(array54);

OrderArrayRows(array54);
System.Console.WriteLine();
PrintArray(array54);

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int ShowRowMinSum(int[,] array)
{
    int[] sumArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
            sumArr[i] = summ;
        }
    }

    int minPosition = 0;
    for (int i = 1; i < sumArr.Length; i++)
    {
        if (sumArr[i] < sumArr[minPosition]) minPosition = i;
    }
    int min = minPosition + 1;
    return min;
}

Console.WriteLine();
int[,] array56 = FillArray(4, 4, 1, 9);
PrintArray(array56);

Console.WriteLine($"\nПрограмма считает сумму элементов в каждой строке \nи выдаёт номер строки с наименьшей суммой элементов: {ShowRowMinSum(array56)} строка\n");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Результатом умножения матриц Am×n и Bn×k будет матрица Cm×k такая,
// что элемент матрицы C, стоящий в i-той строке и j-том столбце (cij), 
// равен сумме произведений элементов i-той строки матрицы A на соответствующие элементы j-того столбца матрицы B:
// cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj


int[,] ResultMultiplieArray(int[,] arrayA, int[,] arrayB)
{
    int[,] resultArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                resultArray[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return resultArray;
}

int[,] array581 = FillArray(2, 2, 1, 9);
int[,] array582 = FillArray(2, 2, 1, 9);
PrintArray(array581);
Console.WriteLine();
PrintArray(array582);

System.Console.WriteLine();
PrintArray(ResultMultiplieArray(array581, array582));



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Fill3dArray()
{
    int[,,] array3d = new int[2, 2, 2];
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                int element = new Random().Next(10, 100);
                if (FindElement(array3d, element)) continue;
                array3d[i, j, k] = element;
            }
        }
    }
    return array3d;
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void Print3dArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k]}{(i, j, k)} ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine();
int[,,] array60 = Fill3dArray();
Print3dArray(array60);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSnailArray()
{
    int rows = 4;
    int cols = 4;
    int[,] arrSnail = new int[rows, cols];
    int value = 0;
    for (int a = 0; a < (Math.Min(rows, cols) + 1) / 2; a++)
    {
        for (int j = a; j < (cols - a); j++)
        {
            value++;
            arrSnail[a, j] = value;
        }
        for (int i = (a + 1); i < (rows - a); i++)
        {
            value++;
            arrSnail[i, (cols - 1 - a)] = value;
        }
        for (int j = (cols - 2 - a); j >= a; j--)
        {
            if (rows % 2 != 0 && a == Math.Min(rows, cols) / 2 && j == cols - a - 2) break;
            value++;
            arrSnail[(rows - a - 1), j] = value;
        }
        for (int i = (rows - a - 2); i > a; i--)
        {
            if (rows % 2 != 0 && a == Math.Min(rows, cols) / 2 && i == rows - a - 2) break;
            value++;
            arrSnail[i, a] = value;
        }
    }
    return arrSnail;
}

void PrintSnailArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] snail = FillSnailArray();
Console.WriteLine();
PrintSnailArray(snail);