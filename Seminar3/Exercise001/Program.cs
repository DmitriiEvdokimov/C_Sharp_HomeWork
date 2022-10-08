// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Vector(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double num = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    return num;
}

Console.Clear();
Console.WriteLine("Найти расстояние между точками A и B в пространстве.");
Console.WriteLine("Введите координаты точки A:");
Console.Write("x(A)=");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("y(A)=");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("z(A)=");
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B:");
Console.Write("x(B)=");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("y(B)=");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("z(B)=");
int zb = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Расстояние между точек A и B равно: {Vector(xa, ya, za, xb, yb, zb):f2}");
