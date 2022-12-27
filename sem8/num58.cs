// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
int n = m;

int[,] matr1 = Create2DArray(m, n, 1, 10);
Print2DArray(matr1);
Console.WriteLine();
int[,] matr2 = Create2DArray(m, n, 1, 10);
Print2DArray(matr2);
Console.WriteLine();
int[,] multiMatr = MultiMatrix(matr1, matr2);
Print2DArray(multiMatr);

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}