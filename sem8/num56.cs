// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = Create2DArray(6, 4, -10, 10);
Print2DArray(matrix);

Console.WriteLine();

FindMinRow(CalcRows(matrix));


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

int[] CalcRows(int[,] matrix)
{
    int index = 0;
    int[] rowSumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        rowSumArray[index] = rowSum;
        index++;
    }
    return rowSumArray;
}

void FindMinRow(int[] rowSumArray)
{
    int indexMin = 0;
    int minRow = rowSumArray[0];
    for (int i = 1; i < rowSumArray.Length; i++)
    {
        if (minRow > rowSumArray[i])
        {
            minRow = rowSumArray[i];
            indexMin = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов:{indexMin + 1}");
}