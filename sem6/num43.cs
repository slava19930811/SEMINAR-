// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine()!);

double xFromFunction = FindX(b1, k1, b2, k2);
double yFromFunction = FindY(xFromFunction, k1, b1);

Console.WriteLine($"Координаты точки пересечения двух прямых: ({xFromFunction};{yFromFunction})");

double FindX(double b1f, double k1f, double b2f, double k2f)
{
    double calculatedX = Math.Round((b2f - b1f) / (k1f - k2f), 1);
    return calculatedX;
}

double FindY(double calculatedX, double k1f, double b1f)
{
    double calculatedY = Math.Round(calculatedX * k1f + b1f, 1);
    return calculatedY;
}