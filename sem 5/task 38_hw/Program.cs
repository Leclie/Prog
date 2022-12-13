// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = GetArray(5, 0, 100);
PrintArray(array);
Console.WriteLine("");
Task(array);

void Task(int[] array)
{
    int min = 101;
    int max = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine("max = " + max);
    Console.WriteLine("min = " + min);
    int res = max - min;
    Console.WriteLine("max - min = " + res);
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