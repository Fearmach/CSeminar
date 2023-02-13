// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

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

int[,] matr = FillMatrix(4, 4);
PrintMatrix(matr);
int min = matr[0, 0];
int minindexi = 0;
int minindexj = 0;
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (matr[i, j] < min)
        {
            min = matr[i, j];
            minindexi = i;
            minindexj = j;
        }
    }
}

int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
int counti = 0;

for (int i = 0; i < matr.GetLength(0); i++)
{
    int countj = 0;
    if (i == minindexi)
        continue;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (j == minindexj)
            continue;
        result[counti, countj] = matr[i, j];
        countj++;
    }
    counti++;
}

System.Console.WriteLine();

PrintMatrix(result);
