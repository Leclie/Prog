// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int Numbers(int sum, int m, int n)
{
    if( n < m  )
    {
        return sum;
    }
    return Numbers(sum + n, m, n - 1);
}
Console.WriteLine(Numbers(0, m, n));