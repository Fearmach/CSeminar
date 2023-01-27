// Написать программу, которая принимает на вход число А и выдает сумму чисел от 1 до А (7 -> 28; 4 -> 10)

int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)    
    {
        sum += i;
    }
    return sum;
}

// Проверка на корректность введенного числа 1 Вариант
// int InputNumber(string str)
// {
//     int number;
//     string text;
//     while(true)
//     {
//         System.Console.WriteLine(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             break;
//         }
//         System.Console.WriteLine("Введено не корректное число, попробуйте еще раз!");
//     }
//     return number;
// }

// Проверка на корректность введенного числа 2 Вариант

int InputNumber(string message)
{
    int number;
    while (true)
    {
        System.Console.WriteLine(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено не корректное число, попробуйте еще раз!");
        }
        else
            break;
    }
    return number;
}

int A = InputNumber("Введите число A: ");
int B = InputNumber("Введите число B: ");

int sumA = Sum(A);
int sumB = Sum(B);

System.Console.WriteLine($"Сумма чисел от 1 до {A} = {sumA} ");
System.Console.WriteLine($"Сумма чисел от 1 до {B} = {sumB} ");

