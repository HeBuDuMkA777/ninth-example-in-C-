using System;
using static System.Console;

Clear();

WriteLine("Введите число - начало отрезка: ");
int numStart = int.Parse(ReadLine());
WriteLine("Введите число - конец отрезка: ");
int numEnd = int.Parse(ReadLine());
WriteLine(GetSumNumbers(numStart, numEnd));

int GetSumNumbers(int start, int end)
{
    if (start == end) return + start;
    {
        return(start + GetSumNumbers(start + 1, end));
    }
}