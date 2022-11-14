// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1

void PrintNumsNto1(int n)
{
    if (n != 0)
    {
        Console.Write($"{n} ");
        PrintNumsNto1(n - 1);
    }
}

Console.WriteLine("Вывести числа от N до 1");
Console.Write("Введите N:");
int n = int.Parse(Console.ReadLine()!);
PrintNumsNto1(n);