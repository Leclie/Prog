// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());
if ( 6 <= day && day <= 7){
    Console.WriteLine("да");
} else if (1 <= day && day <= 5){
    Console.WriteLine("нет");
} else{
    Console.WriteLine("ошибка ввода");
}