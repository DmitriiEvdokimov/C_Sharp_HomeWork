// Задача 25: Напишите цикл, который принимает на вход два числа (A и B),
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exp(int numberA, int numberB)
{
    int expResult = numberA;
    if (numberB < 0)
    {
        numberB = -numberB;
    }
    if (numberB == 0)
    {
        return -1;
    }
    else
    {
        for (int i = 0; i < numberB - 1; i++)
        {
            expResult = expResult * numberA;
        }
    }
    return expResult;
}
void PrintResult(int x, int a1, int b1)
{
    if (x == -1)
    {
        Console.WriteLine("0 не натуральное число");
    }
    else
        Console.WriteLine($"Если возвести {a1} в натуральную степень {b1}, то получится {x}");
}
Console.Clear();
Console.WriteLine("Возвести число A в степень B.");
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine()!);

int totalResult = Exp(A, B);
PrintResult(totalResult, A, B);
