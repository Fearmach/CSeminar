// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве (4;массив (6, 7, 19, 345, 3) - нет  3;массив (6, 7, 19, 345, 3) - да)

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

int InputNum()
{
    System.Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Convert.ToString(System.Console.ReadLine()));
    return num;
}

bool CheckNum(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

int[] mass = FillArrayWithRandomNumbers(10, 0, 30);
PrintArray(mass);
int find = InputNum();

if(CheckNum(find, mass))
{
    System.Console.WriteLine($"{find} Присутствует в массиве");
}
else
{
    System.Console.WriteLine($"{find} Не присутствует в массиве");
}


