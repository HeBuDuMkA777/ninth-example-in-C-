using System;
using static System.Console;

Clear();

int numM = 2; //Условие задачи
int numN = 3; // Условие задачи
WriteLine(GetNumAkkerman(numM, numN));


int GetNumAkkerman(int numberA, int numberB)
{
    if (numberA == 0) return numberB + 1;
    else if (numberB == 0 & numberA > 0) return GetNumAkkerman(numberA - 1, 1);
    else if (numberA > 0 & numberB > 0) return GetNumAkkerman(numberA - 1, GetNumAkkerman(numberA, numberB - 1));
    else return -1;
}
