// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Numbers(int n)
{
    Console.Write(n + " ");
    n--;
    if( n < 1  )
    {
        return;
    }
    Numbers(n);
}


Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Numbers(n);