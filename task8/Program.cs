// // Напишите программу, которая будет принимать на вход два числа и выводить, является ли 2-е число кратным первому. Если число 2 не кратно числу 1, программа выводит остаток от деления (34, 5 -> не кратно, остаток 4; 16, 4 -> Кратно)
System.Console.WriteLine("Введите 1-е число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2-е число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    System.Console.WriteLine($"{num1} кратно {num2}");
}
else
{
    System.Console.WriteLine($"{num1} не кратно {num2}");
}