// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Привет!");
Console.WriteLine("Я могу определить максимальное число из двух введенных чисел.");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine($"Максимальное число, это {a}");
}
else
{
    Console.WriteLine($"Максимальное число, это {b}");
}