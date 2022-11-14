// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


int Ackermann(int m, int n)
{
    Console.WriteLine($"m={m}, n={n}");
    if (m == 0) return n += 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine("Функция Аккермана");
Console.WriteLine("Введите два неотрицательных числа M и N");
Console.Write("Введите M:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N:");
int n = int.Parse(Console.ReadLine()!);
if (m >= 0 && n >= 0) Console.WriteLine(Ackermann(m, n));
else Console.WriteLine("Введите два неотрицательных числа M и N");
    
