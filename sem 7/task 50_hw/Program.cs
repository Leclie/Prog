// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же
// указание, что такого элемента нет.

int[,] matr = GetMatrix(5, 5, 0, 100);
PrintMatrix(matr);
Console.WriteLine("Введите строку");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int col = Convert.ToInt32(Console.ReadLine());

if(row < matr.GetLength(0) && col < matr.GetLength(1))
{
    Console.WriteLine("Ваш элемент: " + matr[row, col]);
} else
{
    Console.WriteLine("Такого элемента нет");
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