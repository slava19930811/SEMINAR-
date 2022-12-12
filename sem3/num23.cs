// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    Console.WriteLine("Некорректный ввод. Повторите попытку");
}

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}