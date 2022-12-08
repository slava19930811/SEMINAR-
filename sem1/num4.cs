//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Write("Введите первое число: ");
string numberA = Console.ReadLine()!;

Console.Write("Введите второе число: ");
string numberB = Console.ReadLine()!;

Console.Write("Введите третье число: ");
string numberC = Console.ReadLine()!;

int number1 = int.Parse(numberA);
int number2 = int.Parse(numberB);
int number3 = int.Parse(numberC);
int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine(max);