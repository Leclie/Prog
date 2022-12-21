// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

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


int[,] GetMatrix(int n)
{
    int[,] matr = new int[n, n];
    
    int row = n, col = n;
    int minRow = 0, maxRow = row - 1, minCol = 0, maxCol = col - 1;
    int count = 0;
    int max = row * col;
    while (count < max) {
        for (int i = minCol; i <= maxCol; i++) {
            matr[minRow,i] = count;
            count++;
        }
        minRow = minRow + 1;
        for (int i = minRow; i <= maxRow; i++) {
            matr[i,maxCol] = count;
            count++;
        }
        maxCol = maxCol - 1;
        for (int i = maxCol; i >= minCol; i--) {
            matr[maxRow,i] = count;
            count++;
        }
        maxRow = maxRow - 1;
        for (int i = maxRow; i >= minRow; i--) {
            matr[i,minCol] = count;
            count++;
        }
        minCol = minCol + 1;
    }
    
    return matr;
}

int[,] matr = GetMatrix(4);
PrintMatrix(matr);