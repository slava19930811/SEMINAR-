// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива"); 
int number1 = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите min"); 
double number2 = double.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите max"); 
double number3 = double.Parse(Console.ReadLine()!); 
 
double[] firstArray = GenerateArray(number1, number2, number3); 
PrintArray(firstArray); 
 
double result = FindMax(firstArray) - FindMin(firstArray); 
 
Console.WriteLine(result); 
 
 
double[] GenerateArray(int size, double min, double max) 
{ 
    double[] array = new double[size]; 
 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 0); 
    } 
 
    return array; 
} 
 
void PrintArray(double[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        Console.Write(array[i] + " "); 
    } 
    Console.WriteLine(); 
} 
 
double FindMin(double[] array) 
{ 
    double mincalc = array[0]; 
    for (int i = 1; i < array.Length; i++) 
    { 
        if (mincalc > array[i]) 
        { 
            mincalc = array[i]; 
        } 
    } 
    return mincalc; 
} 
 
double FindMax(double[] array) 
{ 
    double maxcalc = array[0]; 
    for (int i = 1; i < array.Length; i++) 
    { 
        if (maxcalc < array[i]) 
        { 
            maxcalc = array[i]; 
        } 
    } 
    return maxcalc; 
}