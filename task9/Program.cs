﻿// Написать программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23 ( 14 - нет, 161 - да)

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"{num} не кратно 7 и 23");
}
