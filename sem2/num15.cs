﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("да - Выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("не день недели");
  }
  else Console.WriteLine("нет - Будний день");
}

CheckingTheDayOfTheWeek(dayNumber);
