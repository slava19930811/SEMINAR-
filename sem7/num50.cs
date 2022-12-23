// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет


Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n, -10, 10);
Print2DArray(matrix);

Console.WriteLine();

Console.WriteLine("Введите первую позицию элемента");
int positionM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую позицию элемента");
int positionN = int.Parse(Console.ReadLine()!);

FindElement(matrix, positionM, positionN);


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

void FindElement(int[,] matrix, int position1, int position2)
{
    if (0 <= position1 && position1 < matrix.GetLength(0))
    {
        if (0 <= position2 && position2 < matrix.GetLength(1))
        {
            Console.WriteLine(matrix[position1, position2]);
        }
        else Console.WriteLine("Такого элемента не существует");
    }
    else Console.WriteLine("Такого элемента не существует");
}