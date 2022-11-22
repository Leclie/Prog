// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите 1е число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2е число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3е число:");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3){
    Console.WriteLine(num1);
}
if (num2 > num1 && num2 > num3){
    Console.WriteLine(num2);
}
if (num3 > num2 && num3 > num1){
    Console.WriteLine(num3);
}