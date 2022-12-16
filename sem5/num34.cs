// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Размер массива вводим через консоль
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");
int number1 = int.Parse(Console.ReadLine()!);

int[] firstArray = GenerateArray(number1);
PrintArray(firstArray);

Console.WriteLine(CountEven(firstArray));

int[] GenerateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}