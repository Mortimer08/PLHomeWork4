﻿// Задача 27: Напишите программу, которая
// принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitsSum = DigitsSum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {digitsSum}");

int DigitsSum(int num)
{
    num = Math.Abs(num);
    int sum = 0;
    while (num >= 1)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}