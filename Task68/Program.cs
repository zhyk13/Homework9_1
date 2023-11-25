// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InputNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    int A = 0;
    if (m == 0)
    {
        return A = n + 1;
    }
    else
    {
        if (n == 0)
        {
            return A = Akkerman(m-1, 1);
        }
        else
        {
           return A = Akkerman(m-1, Akkerman(m, n-1));
        }
    }
}

int numM = InputNumber("Введите положительное число M: ");
int numN = InputNumber("Введите положительное число N: ");
if ((numM < 0) || (numN < 0))
{
    Console.WriteLine("Введены недопустимые значения");
}
else
{
    Console.WriteLine($"Значение функции Аккермана при М={numM} и N={numN} равно {Akkerman(numM, numN)}");
}
