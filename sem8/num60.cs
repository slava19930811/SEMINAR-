// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k");
int k = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(m, n, k, 10, 100);
int[,,] mainMatrix = Fill3DArray(arr);
Print3DArray(mainMatrix);

int[] CreateArray(int m, int n, int k, int min, int max)
{
    int[] array = new int[m * n * k];
    for (int i = 0; i < array.Length; i++)
    {
        int value = new Random().Next(min, max);
        if (array.Contains(value)) i--;
        else array[i] = value;
    }
    return array;
}

int[,,] Fill3DArray(int[] array)
{
    int[,,] matrix = new int[m, n, k];
    int i = 0;
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                matrix[x, y, z] = array[i];
                i++;
            }

        }
    }
    return matrix;
}

void Print3DArray(int[,,] matrix)
{
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                Console.Write($"{matrix[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}