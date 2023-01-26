// Написать программу, которая принимает на вход координаты точки (x, y), причем x и y не равны 0 и выдает номер четверти плоскости, в которой находится эта точка

int[] coords = new int[2];

System.Console.WriteLine("Введите координаты x: ");
coords[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if(coords[0] > 0 && coords[1] > 0)
{
    System.Console.WriteLine("Номер четверти 1");
}
else if(coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine("Номер четверти 2");
}
else if(coords[0] < 0 && coords[1] < 0)
{
    System.Console.WriteLine("Номер четверти 3");
}
else if (coords[0] > 0 && coords[1] < 0)
{
    System.Console.WriteLine("Номер четверти 4");
}
else
{
    System.Console.WriteLine("Точка находится в центре системы координат");
}