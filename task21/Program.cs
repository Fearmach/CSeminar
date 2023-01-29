// Написать программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот (-4, -8, 8, 2 -> 4, 8, -8, -2)

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange) // СОЗДАЛИ ФУНКЦИЮ
{
    int[] arr = new int[size]; // СОЗДАЛИ МАССИВ И ВЫДЕЛИЛИ НА НЕГО ПАМЯТЬ
    Random rand = new Random(); // МЕТОД ЗАПОЛНЕНИЯ
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr) // ФУНКЦИЯ ВЫВОДА
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]"); // string.Join Позволяет вывести все элементы массива например через (,  )
}

void ArrayChange (int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
    array[i] = array[i] * (-1);

}
}

int[] array = FillArrayWithRandomNumbers(4, -9, 9);

ArrayChange(array);
PrintArray(array);