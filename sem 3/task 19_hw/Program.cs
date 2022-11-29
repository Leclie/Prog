// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 10 == number / 10000){
    if (number % 100 / 10 == number / 1000 % 10){
        Console.WriteLine("Да");
    } else{
        Console.WriteLine("Нет");
    }
} else{
    Console.WriteLine("Нет");
}