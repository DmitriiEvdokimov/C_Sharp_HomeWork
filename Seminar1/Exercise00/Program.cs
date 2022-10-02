// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Привет!");
Console.WriteLine("Я могу определить какое из двух чисел больше, а какое меньше.");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.WriteLine($"{a} больше, чем {b}");
}
else
{
    Console.WriteLine($"{b} больше, чем {a}");
}