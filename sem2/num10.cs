//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введи трёхзначное число: ");
int amountDigit = Convert.ToInt32(Console.ReadLine());
string numberA = Convert.ToString(amountDigit);
Console.WriteLine("вторая цифра этого числа "+ numberA[1]);
