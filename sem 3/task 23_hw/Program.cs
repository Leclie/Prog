// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num){
    Console.WriteLine(i * i * i);
    i = i + 1;
}