// Не используя рекурсию, выведите первые N чисел Фибоначи. Первые два числа 0 и 1. (Если N = 5 -> 0 1 1 2 3, N = 7-> 0 1 1 2 3 5 8)

int InputNum(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Convert.ToString(System.Console.ReadLine()));
    return num;
}

int n = InputNum("Введите число: ");
int n1 = 0;
int n2 = 1;
System.Console.Write("0,1");

for (int i = 0; i < n - 2; i++)
{
    int fib = n1 + n2;
    System.Console.Write($",{fib}");
    n1 = n2;
    n2 = fib;
}

