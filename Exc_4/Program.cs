//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные сила от 1 до N

Console.WriteLine("Введите число: ");

int N = int.Parse(Console.ReadLine());
int count = 1;

if (N > 0)
{
    while (count <= N)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
        }

        count++;
    }
}
else
{
    while (count >= N)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
        }

        count--;
    }
}