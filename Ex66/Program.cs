﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumRec(int m, int n)
{
    if (m == n) return n;
    else return SumRec(m, n-1) + n;

}
Console.WriteLine(SumRec(M, N));