// Задача 8: Напишите программу, которая на вход принимает число (n),
// а на выходе показывает все чётные числа от 1 до n.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Привет!");
Console.WriteLine("Я могу показать все четные числа от 1 до n");
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
int num = 1;
Console.Write("Вот эти числа: ");
if (n > num)
{
    while (num <= n)
    {
        if (num % 2 == 0)
        {
            Console.Write($"{num} ");
            num = num + 1;
        }
        else
        {
            num = num + 1;
        }
    }
}
else
{
    while (num >= n)
    {
        if (num % 2 == 0)
        {
            Console.Write($"{num} ");
            num = num - 1;
        }
        else
        {
            num = num - 1;
        }
    }
}


