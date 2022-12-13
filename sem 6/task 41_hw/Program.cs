// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string str = "";
Console.WriteLine("Введите числа:");
int count = 0;

while(String.Compare(str, "stop") != 0)
{
    str = Console.ReadLine();
    int numericValue;
    bool isNumber = int.TryParse(str, out numericValue);
    if(isNumber)
    {
        if(numericValue > 0)
        {
            count++;
        }
    }
}
Console.WriteLine("count = " + count);