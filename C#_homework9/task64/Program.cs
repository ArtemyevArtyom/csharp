﻿/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Введите число N");
int userNumber = Convert.ToInt32(Console.ReadLine());

void printRange(int N)
{
    if (N == 1) return;
    Console.Write($"{N}, ");
    printRange(N - 1);
    
}

printRange(userNumber);
Console.Write($"1");