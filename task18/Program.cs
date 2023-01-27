// Написать программу, которая принимает на вход число N и выдает произведение чисел от 1 до N (4 - 24, 5 - 120)

 int InputNumber(string str)
 {
     int number;
     string text;
     while(true)
     {
         System.Console.WriteLine(str);
         text = Console.ReadLine();
         
         if (int.TryParse(text, out number))
         {
             break;
         }
         System.Console.WriteLine("Введено не корректное число, попробуйте еще раз!");
     }
     return number;
}

int N = InputNumber("Введите число: ");

int Math_Method(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res *= i;
    }
    return res;
}
int result = Math_Method(N);
System.Console.WriteLine(result);
