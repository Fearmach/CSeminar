// Задайте двумерный массив размера rows на cols, каждый элемент в массиве находится по формуле Arols,cols = rols + cols. Вывести массив на экран m=3, n=4 0123; 1234; 2345


int[,] ArrayFill(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++) 
        { 
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }

}

System.Console.WriteLine("Введите rols и cols: ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = ArrayFill(rows, cols);
System.Console.WriteLine();
PrintMatrix(matrix);