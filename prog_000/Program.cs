/*
**Задача 70:** Напишите программу, которая на вход принимает два числа и выдаёт первые N
чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

using System;
using static System.Console;

Clear();

WriteLine("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите N: ");
int n = Convert.ToInt32(ReadLine());
Write($"{a} {b} ");
PrintSumNumbers(a, b, n - 2);

void PrintSumNumbers(int first, int second, int stop)
{
    if (stop > 0)
    {
        Write($"{first + second} ");
        stop--;
        first += second;
        PrintSumNumbers(second, first, stop);
    }
}
