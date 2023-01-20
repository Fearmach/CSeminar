// Написать программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N: 2 -> "-2, -1, 0, 1, 2"

//System.Console.WriteLine("Введите число "); // Рабочая версия через FOR
//int N = Convert.ToInt32(Console.ReadLine());

//for (int i = -N; i <= N; i++)
    //{
   //     System.Console.WriteLine(i);
   // }



//System.Console.Write("Введите число: "); // РАБОЧАЯ ВЕРСИЯ из лекции, не выводит последнее число
//int N = Convert.ToInt32(Console.ReadLine());
//int M = N * -1;

//while (M != N)
//{
//    System.Console.WriteLine(M);
  //  M += 1;
//}

System.Console.WriteLine("Введите число "); // МОЯ ВЕРСИЯ
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;

while(i <= N){
    {
        System.Console.WriteLine(i);
        i = i + 1; 
    }
}
