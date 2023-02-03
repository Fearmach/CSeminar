// Решить программ, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник с сторонами такой длинны.


int InputNum(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Convert.ToString(System.Console.ReadLine()));
    return num;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]"); 
}

int n1 = InputNum("Введите 1 число: ");
int n2 = InputNum("Введите 2 число: ");
int n3 = InputNum("Введите 3 число: ");

if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2)
{ 
    System.Console.WriteLine("Треугольник может существовать");
}
else
{ 
    System.Console.WriteLine("Треугольник существовать не может");
}

