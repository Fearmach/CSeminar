// Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2d пространстве (A (3,6); B(2,1) - 5,09)

double[] coordsA = new double[2];
double[] coordsB = new double[2];

System.Console.WriteLine("Введите координаты x, точки A: ");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y, точки A: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты x, точки B: ");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y, точки B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow (coordsA[1] - coordsB[1],2) + Math.Pow (coordsA[0] - coordsB[0],2));

System.Console.WriteLine(S);