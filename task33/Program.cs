// Задайте двумерный массив. Найдите сумму элементов находящихся на главной диагонали с индексами (0,0; 1,1 и.т.д.)

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 50);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int MatrixEdit(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i == j))
            {
                result += matrix[i,j];
            }
        }
    }
    return result;
}
System.Console.WriteLine("Введите rows и cols: ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array2d = FillMatrix(rows,cols);
PrintMatrix(array2d);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов = {MatrixEdit(array2d)}");
