// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("Введите два числа");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = int.Parse(Console.ReadLine()!);

int MultFromFunction = Power(numberA, numberB);
Console.WriteLine(MultFromFunction);

int Power(int numA, int numB)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}
