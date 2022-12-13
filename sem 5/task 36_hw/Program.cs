// Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = GetArray(5, -10, 10);
PrintArray(array);
Console.WriteLine("");
int num = Task(array);
Console.WriteLine(num);


int Task(int[] array)
{
    int num = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        num += array[i];
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