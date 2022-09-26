// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int MinLine(int[,] arr)
{
    int minLine = 0;
    int sumLine = LineValue(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int temp = LineValue(arr, i);
        if (temp < sumLine)
        {
            sumLine = temp;
            minLine = i;
        }
    }
    return minLine;
}

int LineValue(int[,] arr, int i)
{
    int sumLine = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sumLine += arr[i, j];
    }
    return sumLine;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 99);
Console.WriteLine();
PrintMatrix(array2D);
int minLineResult = MinLine(array2D);
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой элементов: {minLineResult + 1}");
Console.WriteLine();