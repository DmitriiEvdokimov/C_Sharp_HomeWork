// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumsBetweenMN(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m += SumNumsBetweenMN(m + 1, n);
}

Console.WriteLine("Сумма натуральных чисел от M до N.");
Console.Write("Введите M:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма равна {SumNumsBetweenMN(m, n)}");