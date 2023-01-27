// Написать программу, которая принимает на вход число и выдает количество цифр в числе (456 - 3, 78 - 2)

// Проверка на корректность введенного числа 1 Вариант

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

int num = InputNumber("Введите число: ");
string numString = Convert.ToString(num);
int length = numString.Length;
System.Console.WriteLine(length);