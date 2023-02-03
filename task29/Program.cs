// Написать программу, которая будет создавать копию заданного массива с помощью поэлементного копирования


int[] FillArray(int size, int leftRange, int rightRange)
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

// ВАРИАНТ БЕЗ ФУНКЦИИ

// int[] array = FillArray(4, 0, 10);
// PrintArray(array);

// int[] otherarray = new int[4];

// for (int i = 0; i < array.Length; i++)
// {
//     otherarray[i] = array[i];
// }

// PrintArray(otherarray);

// ВАРИАНТ С ФУНКЦИЕЙ

int[] ArrayCopying(int[] array)
{
    int[] arraycopy = new int[array.Length];
    for (int i = 0; i < arraycopy.Length; i++)
    {
        arraycopy[i] = array[i];
    }
    return arraycopy;
}

int[] arr = FillArray(5, 0, 10);
PrintArray(arr);
int[] arr2 = ArrayCopying(arr);
PrintArray(arr2);

// ВАРИАНТ В 1 СТРОКУ (ТАКОЙ ВАРИАНТ НЕ СОХРАНЯЕТ 2-Й МАССИВ, ЕСЛИ МЕНЯТЬ ПЕРВЫЙ ПРИНУДИТЕЛЬНО, ИЗМЕНИТСЯ И 2-Й)

// int[] arr = FillArray(5, 0, 10);
// PrintArray(arr);
// int[] arr2 = arr; 
// PrintArray(arr2);