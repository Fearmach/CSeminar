// Написать программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и.т.д) (1 2 3 4 5 -> 5 4 3 2 1)

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

void ReverseArray (int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length-i-1];
        arr[arr.Length-i-1] = temp;
    }
}

int[] array = FillArray( 10, 0, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);