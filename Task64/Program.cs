using System;
using static System.Console;

Clear();

WriteLine("Введите число - начало отрезка: ");
int numStart = int.Parse(ReadLine());
WriteLine("Введите число - конец отрезка: ");
int numEnd = int.Parse(ReadLine());
WriteLine(GetNumbers(numStart, numEnd));





string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    {
        return (start + " " + GetNumbers(start + 1, end));
    }
}