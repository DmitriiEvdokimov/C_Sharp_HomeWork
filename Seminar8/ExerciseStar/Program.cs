// Задача "со звездочкой": Написать функцию Sqrt(x) - квадратного корня,
//  которая принимает на вход целочисленное значение x
//  и возвращает целую часть квадратного корня от введенного числа.
// 4 -> 2
// 28 -> 5

int Sqrt()
{
    Console.Clear();
    Console.WriteLine("Извлечение квадратного корня из числа. ");
    Console.Write("Введите число: ");
    double userX = int.Parse(Console.ReadLine()!);
    if (userX == 1)
    {
        Console.Write($"Целая часть квадратного корня = ");
        Console.WriteLine(1); 
        return 1;
    }
    if (userX == 0)
    {
        Console.Write($"Целая часть квадратного корня = ");
        Console.WriteLine(0); 
        return 0;
    }
    double x = userX;
    int result = 1;
    int count2 = 0;
    int count3 = 0;
    int count5 = 0;
    int count7 = 0;

    while (x > 1 || count2 == 1 || count3 == 1 || count5 == 1 || count7 == 1)
    {
        x = userX;
        result = 1;
        count2 = 0;
        count3 = 0;
        count5 = 0;
        count7 = 0;
        while (x % 2 == 0) { x /= 2; count2++; }
        while (x % 3 == 0) { x /= 3; count3++; }
        while (x % 5 == 0) { x /= 5; count5++; }
        while (x % 7 == 0) { x /= 7; count7++; }
        for (int i = 0; i < count2 / 2; i++) result *= 2;
        for (int i = 0; i < count3 / 2; i++) result *= 3;
        for (int i = 0; i < count5 / 2; i++) result *= 5;
        for (int i = 0; i < count7 / 2; i++) result *= 7;
        if (x == 1 && count2 != 1 && count3 != 1 && count5 != 1 && count7 != 1)
        {
            Console.Write($"Целая часть квадратного корня = ");
            Console.WriteLine(result);
            return result;
        }
        userX = userX - 1;
    }
    Console.Write("Извлечение квадратного корня невозможно");
    return -1;
}

Sqrt();
