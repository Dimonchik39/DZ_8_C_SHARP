// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void SortDescending(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int j2 = 0; j2 < arr.GetLength(1) -1; j2++)
            {
                if (arr[i, j2] < arr[i, j2 + 1])
                {
                    int temp = arr[i, j2 + 1];
                    arr[i, j2 + 1] = arr[i, j2];
                    arr[i, j2] = temp;
                }
            }
        }
    }
}

int[,] array2D = CreateMatrixRndInt(4, 6, 1, 99);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintMatrix(array2D);
SortDescending(array2D);
Console.WriteLine();
Console.WriteLine("Выполнена сортировка по убыванию в строках:");
PrintMatrix(array2D);
Console.WriteLine();
