// Задать двумерный массив. Найти элементы у которых оба индекса нечетные и заменить эти элементы на их квадраты (задан 1 4 7 2 = 1 4 7 2; 5 9 2 3 = 5 81 2 9)

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

void MatrixEdit(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i % 2 != 0) && (j % 2 != 0))
            {
                matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
            }
        }
    }
}

int[,] matrix = FillMatrix(3, 3);
PrintMatrix(matrix);
System.Console.WriteLine();
MatrixEdit(matrix);
PrintMatrix(matrix);
