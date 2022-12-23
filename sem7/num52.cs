// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n, -10, 10);
Print2DArray(matrix);

Console.WriteLine();

FindDirectAverage(matrix);


int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindDirectAverage(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double countForDirectAverage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            countForDirectAverage += matrix[i, j];
        }
        double countDirectAverage = Math.Round(countForDirectAverage / matrix.GetLength(0), 1);
        Console.WriteLine(countDirectAverage);
    }
}