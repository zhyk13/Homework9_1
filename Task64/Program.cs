﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void RoadToN(int number)
{
    if (number == 0)
    {
        return;
    }
    System.Console.Write($"{number} ");
    RoadToN(number - 1);
}


int N = InputNumber("Введите число: ");
RoadToN(N);
