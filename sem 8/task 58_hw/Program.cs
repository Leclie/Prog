// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
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

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] task(int[,] matr1, int[,] matr2){
    int[,] resMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if(matr1.GetLength(0) == matr2.GetLength(0) && matr1.GetLength(1) == matr2.GetLength(1)){
        for(int i = 0; i < resMatr.GetLength(0); i++){
            for(int j = 0; j < resMatr.GetLength(1); j++){
                resMatr[i, j] = matr1[i, j] * matr2[i, j];
            }
        }
    } else{
        Console.WriteLine("Матрицы разной размерности!");
    }
    return resMatr;
}



int rows1 = GetNumber("Введите число строк первой матрицы");
int columns1 = GetNumber("Введите число столбцов первой матрицы");
int[,] matrix1 = GetMatrix(rows1, columns1);
PrintMatrix(matrix1);
Console.WriteLine();

int rows2 = GetNumber("Введите число строк второй матрицы");
int columns2 = GetNumber("Введите число столбцов второй матрицы");
int[,] matrix2 = GetMatrix(rows2, columns2);
PrintMatrix(matrix2);
Console.WriteLine();


int[,] resMatr = task(matrix1, matrix2);
PrintMatrix(resMatr);