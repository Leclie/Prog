// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetMatrix(int x, int y, int z, int leftRange = 10, int rightRange = 99)
{
    int[,,] matr = new int[x, y, z];
    int num = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = num++;
            }
        }
    }
    return matr;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i, j, k] + "(" + i + ", " + j + ", " + k + ") ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


int x = GetNumber("Введите x");
int y = GetNumber("Введите y");
int z = GetNumber("Введите z");
int[,,] matrix = GetMatrix(x, y, z);
if(x * y * z > 90){
    Console.WriteLine("Слишком большая размерность для двухзначных чисел");
} else{
    PrintMatrix(matrix);
}
