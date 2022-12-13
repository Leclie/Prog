// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] matr = GetMatrix(5, 4, -10, 10);
PrintMatrix(matr);

double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
{
    double[,] matr = new double[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(rand.NextDouble()* (rightRange - leftRange) + leftRange, 1);
        }
    }

    return matr;
}

void PrintMatrix(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}