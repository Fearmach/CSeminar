// Написать программу, которая на вход принимает 2 числа и проверяет, является ли 1-е квадратом 2-го 
// например a = 25, b = 5 -> да; a = 2, b = 10 -> нет;...

System.Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 * num2 == num1)
{
    System.Console.Write($"{num1} является квадратом {num2}");
}
else 
{
    System.Console.Write($"{num1} не является квадратом {num2}");
}
