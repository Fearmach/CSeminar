// Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке (1,0,1,1,0,1,0,0)

 int[] array = new int[8];
 Random rand = new Random();

 for (int i = 0; i < array.Length; i++)
 {
     array[i] = rand.Next(0, 2);
    //  System.Console.WriteLine(array[i] + " ");
 }
 

 System.Console.WriteLine(string.Join(", ", array)); 

// void FillArray(int[] collection)
// {
//     int length = 8;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0,2);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = 8;
//     int pos = 0;
//     while (pos < count)
//     {
//         System.Console.WriteLine(col[pos]);
//         pos++;
//     }
// }

// int[] array = new int [8];

// FillArray(array);
// PrintArray(array);


