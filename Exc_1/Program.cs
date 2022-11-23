//Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите 2 числа: ");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

int min = 0;
int max = 0;

if (first > second)
{
    max = first;
    min = second;
}
else
{
    max = second;
    min = first;
}

Console.Write("Максимальное из чисел: ");
Console.WriteLine(max);
Console.Write("Минимальное из чисел: ");
Console.WriteLine(min);