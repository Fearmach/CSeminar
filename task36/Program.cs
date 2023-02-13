// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
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

int[,] matr = FillMatrix(3, 4);
PrintMatrix(matr);
int[] result = new int[10];

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        result[matr[i, j]]++;
    }
    System.Console.WriteLine();
}
System.Console.WriteLine(string.Join(" ", result));

for (int i = 0; i < result.Length; i++)
{
    if (result[i] != 0)
    {
        System.Console.WriteLine($"{i} встречается {result[i]} раз");
    }
}
