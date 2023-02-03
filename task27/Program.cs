// Написать программу, которая будет преобразовывать десятичное число в двоичное (45 -> 101101; 3 -> 11)


void GetBinaryView(int numb)
{
    if (numb <= 0) return;
    GetBinaryView(numb / 2);
    System.Console.Write(numb % 2);
}

int Numb (string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Convert.ToString(System.Console.ReadLine()));
    return num;
}

int N = Numb("Введите число: ");
GetBinaryView(N);