
int number = new Random().Next(10, 100);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 10;
Console.WriteLine($"Первая цифра - {digit1}, вторая цифра - {digit2}");