﻿int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
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

int Task(int[,] matr)
{
    int sum = 0;
    int length = 0;
    if(matr.GetLength(0) > matr.GetLength(1))
    {
        length = matr.GetLength(1);
    } else
    {
        length = matr.GetLength(0);
    }
    for (int i = 0; i < length; i++)
    {
        sum += matr[i,i];
    }
    return sum;
}

int[,] matr = GetMatrix(4, 5, 3, 9);
PrintMatrix(matr);
int sum = Task(matr);
Console.WriteLine();
Console.WriteLine(sum);
