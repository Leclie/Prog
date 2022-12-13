// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matr = GetMatrix(3, 3, 0, 10);
PrintMatrix(matr);
Console.WriteLine();

for (int j = 0; j < matr.GetLength(1); j++)
{
    double mid = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        mid += matr[i, j] + 0.0;
    }
    mid /= matr.GetLength(0);
    Console.Write(Math.Round(mid, 1) + " ");
}









int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
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