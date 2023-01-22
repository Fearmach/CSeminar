// Написать программу которая принимает на вход 2 числа и проверяет является ли одно число квадратом другого

System.Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    System.Console.Write($"{num1} является квадратом {num2}");
}
else if (num2 == num1 * num1 )
{
    System.Console.Write($"{num2} является квадратом {num1}");
}
else
{
    System.Console.WriteLine($"{num1} не является квадратом {num2}");
}