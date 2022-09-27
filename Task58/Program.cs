// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationMatrix(int[,] matr, int[,] matr2)
{
    int[,] matrixResult = new int[matr.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int total = default;
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                total += matr[i, k] * matr2[k, j];
            }
            matrixResult[i, j] = total;
        }    
    }
    return matrixResult;
}

Console.WriteLine();
int[,] array = CreateMatrixRndInt(4, 4, 1, 9);
Console.WriteLine("Первая матрица:");
PrintMatrix(array);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(4, 4, 1, 9);
Console.WriteLine("Вторая матрица:");
PrintMatrix(array2);
Console.WriteLine();
int[,] array3 = MultiplicationMatrix(array, array2);
Console.WriteLine("Произведение матриц:");
PrintMatrix(array3);
Console.WriteLine();