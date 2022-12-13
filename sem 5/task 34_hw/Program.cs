// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = GetArray(5, 100, 999);
PrintArray(array);
Console.WriteLine("");
int num = Task(array);
Console.WriteLine(num);





int Task(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            num++;
        }
    }
    return num;
}

int[] GetArray(int length, int leftRange=0, int rightRange=50)
{
    int[] array = new int[length];
    Random rand = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}