// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Coordinates(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;
    double[] result = { x, y };
    return result;
}

void PrintArray(double[] col)
{
    Console.Write("Координаты точки пересечения равны: (");
    Console.Write(String.Join(" ,", col));
    Console.Write(")");
}

Console.Clear();
Console.WriteLine("Найти точку пересечения двух прямых по уравнению y = k * x + b");
Console.WriteLine("Введите число b для первой прямой");
Console.Write("b1=");
double userB1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите угловой коэфициент k для первой прямой");
Console.Write("k1=");
double userK1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b для второй прямой");
Console.Write("b2=");
double userB2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите угловой коэфициент k для второй прямой");
Console.Write("k2=");
double userK2 = double.Parse(Console.ReadLine()!);

if (userK1 == userK2 && userB1 == userB2) Console.WriteLine("Прямые совпадают");
else if (userK1 == userK2) Console.WriteLine("Прямые параллельны.");
else
{
    double[] result = Coordinates(userB1, userK1, userB2, userK2);
    PrintArray(result);
}