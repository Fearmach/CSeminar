// Написать программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N (5 -> 1, 4, 9, 16, 25; 2 -> 1, 4)

// System.Console.WriteLine("Введите число: ");
// double N = Convert.ToInt32(Console.ReadLine());

// for (double i = 0; i < N; i++)
// {
//     System.Console.WriteLine($"{Math.Pow(N, 2)}");
// }

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
double answer = 0;

if (N > 0)
{
    while (count <= N)
    {
        answer = Math.Pow(count,2);
        System.Console.WriteLine(answer);
        count ++;
    }
}
else
{
    System.Console.WriteLine("Не корректное число");
}


