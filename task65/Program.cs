﻿//Семинар// Задача 65: Задайте значения M и N. 
//Напишите программу, которая выведет 
//все натуральные числа в промежутке 
//от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.Clear();
Console.Write("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int m, int n)
{
    if(m < n)
    {
        Console.Write($"{m} ");
        NaturalNumbers(m + 1, n);
    }
    if(m > n)
    {
        Console.Write($"{m} ");
        NaturalNumbers(m - 1, n);
    }
    if(m == n)
    {
        Console.Write($"{m} ");
    }
}
 
NaturalNumbers(number1, number2);