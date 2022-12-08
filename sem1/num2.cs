//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3Console.Write("Введите первое число: ");

Console.Write("Введите первое число: ");
string A = Console.ReadLine()!;

Console.Write("Введите второе число: ");
string B = Console.ReadLine()!;

int parsed1 = int.Parse(A);
int parsed2 = int.Parse(B);

if (parsed1 > parsed2)
    Console.WriteLine("a > b");

else
    Console.WriteLine("a <= b");

