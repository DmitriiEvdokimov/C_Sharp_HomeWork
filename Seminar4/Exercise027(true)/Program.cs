// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum = sum + number%10;
        number = number / 10;
    }
    if(sum<0)
    {
        sum = -sum;
    }
    return sum;
    
}

Console.Clear();
Console.WriteLine("Сумма цифр в числе.");
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()!);
int result = SumDigits(A);
Console.WriteLine($"Сумма цифр в числе равна {result}");