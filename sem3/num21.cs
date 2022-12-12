// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату X точки A");
double x1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки A");
double y1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки А");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B");
double x2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки B");
double y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки B");
double z2 = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(distance);

