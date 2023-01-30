// Задайте одномерный массив из 123 случайных чисел, найти кол-во элементов массива, значения которых лежат (10, 99) пример для 5 (5,18,123,6,2 -> 1; (1,2,3,6,2 -> 0))

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int CheckNumber (int[] array, int leftRange, int rightRange)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= leftRange && array[i] <= rightRange)
        {
            count++;
        }
    }
    return count;
}

int[] mass = FillArrayWithRandomNumbers(10, -100, 100);
PrintArray(mass);
System.Console.WriteLine($"Количество элементов от 10 до 99 = {CheckNumber(mass, 10, 99)}");
