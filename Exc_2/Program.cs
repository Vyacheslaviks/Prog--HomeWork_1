//Напишите программу, которая принимает на вход 3 числа и выдает максиальное из этих чисел

Console.WriteLine("Введите 3 числа:");

int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int max = first;

if (second > max)
{
    max = second;
}
if (third > max)
{
    max = third;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);