﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка {-9 - 9}. Найдите сумму отрицательных и положительных элементов массива. в массиве (3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6) сумма положительных = 29, отрицательных -20

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange) // СОЗДАЛИ ФУНКЦИЮ ЗАПОЛНЕНИЯ МАССИВА
{
    int[] arr = new int[size]; // СОЗДАЛИ МАССИВ И ВЫДЕЛИЛИ НА НЕГО ПАМЯТЬ
    Random rand = new Random(); // МЕТОД ЗАПОЛНЕНИЯ
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void SumPositiveAndNegativeElements(int[] arr, out int sumP, out int sumN);

{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i];
        }
    }
}

void PrintArray(int[] arr) // ФУНКЦИЯ ВЫВОДА
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]"); // string.Join Позволяет вывести все элементы массива например через (,  )
}

int[] array = FillArrayWithRandomNumbers(6, -9, 9); // СОЗДАЛИ МАССИВ И ВЫДЕЛИЛИ НА НЕГО ПАМЯТЬ

PrintArray(array);

SumPositiveAndNegativeElements(array, out int sumP, out int sumN);

System.Console.WriteLine($"Сумма положительных чисел = {sumP}, Отрицательных = {sumN}");
