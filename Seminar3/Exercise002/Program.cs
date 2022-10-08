// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Sqrt(int n)
{
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(Math.Pow(i, 3));
            if (i != n)
                Console.Write(", ");
        }
    }
    else
    {
        for (int i = 1; i >= n; i--)
        {
            Console.Write(Math.Pow(i, 3));
            if (i != n)
                Console.Write(", ");
        }
    }
}

Console.Clear();
Console.WriteLine("Таблица кубов чисел от 1 до N");
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
Sqrt(N);