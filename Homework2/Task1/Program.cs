﻿// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}