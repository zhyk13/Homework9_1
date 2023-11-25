// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFromTo(int start, int stop)
{
    if (stop < start)
    {
        return 0;
    }
    else
    {
        return start + SumFromTo(start + 1, stop);
    }
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
  if (n < m)
    {
        m = m + n;
        n = m - n;
        m = m -n;
    }
Console.WriteLine($"Сумма чисел от М до N равна {SumFromTo(m, n)}.");
