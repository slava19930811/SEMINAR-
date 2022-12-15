// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine()!);

int SumFromFunction = sumDigit(numb);
Console.WriteLine(SumFromFunction);

int sumDigit(int NumberA)
{
    int sum = NumberA % 10;
    while (NumberA > 9)
    {
        NumberA = NumberA / 10;
        sum = sum + NumberA % 10;
    }
    return sum;
}