// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int res = 0;

while (num / 10 > 0){
    res += num % 10;
    num /= 10;
}
res += num;
Console.WriteLine(res);