// Задайте массив из 12 элементов, заполненный случайными числами из промежутка {-9 - 9}. Найдите сумму отрицательных и положительных элементов массива. в массиве (3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6) сумма положительных = 29, отрицательных -20

// int InputNumber(string str)
//  {
//      int number;
//      string text;
//      while(true)
//      {
//          System.Console.WriteLine(str);
//          text = Console.ReadLine();
         
//          if (int.TryParse(text, out number))
//          {
//              break;
//          }
//          System.Console.WriteLine("Введено не корректное число, попробуйте еще раз!");
//      }
//      return number;
// }

int[] array = new int[12]; // СОЗДАЛИ МАССИВ И ВЫДЕЛИЛИ НА НЕГО ПАМЯТЬ
Random rand = new Random();

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}

System.Console.WriteLine("["+string.Join(", ", array) + "]"); // string.Join Позволяет вывести все элементы массива например через (,  )

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}

System.Console.WriteLine($"Сумма положительных чисел = {sumPositive}, Отрицательных = {sumNegative}");