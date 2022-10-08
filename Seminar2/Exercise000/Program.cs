//Задача 10 : Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Показать вторую цыфру трехзначного числа.");
Console.WriteLine("Введите трехзначное число:");
int x = int.Parse(Console.ReadLine()!);
int result ;
int x1 = x / 10;
if (x1 >= 10 && x1 < 100)
{
    result = x % 100 / 10;
    Console.WriteLine($"Вторая цыфра числа {x} -> {result} ");
}
else
{
    Console.WriteLine("Число не трехзначное.");
}
