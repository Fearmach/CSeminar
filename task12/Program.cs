// Написать программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x, y).

string[] array = {"x > 0, y < 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "введено не корректное число"};

System.Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

if( num == 1)
{
    System.Console.WriteLine(array[0]);
}
else if( num == 2)
{
    System.Console.WriteLine(array[1]);
}
else if( num == 3)
{
    System.Console.WriteLine(array[2]);
}
else if ( num == 4)
{
    System.Console.WriteLine(array[3]);
}
else
{
    System.Console.WriteLine(array[4]);
}
