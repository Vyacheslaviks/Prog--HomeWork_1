//Напишите программу, которая на вход приимает число и выдаёт - является ли оно чётным

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число НЕ четное");
}