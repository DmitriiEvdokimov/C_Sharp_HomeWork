//Задача 13: Напишите программу,
//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Показать третью цыфру  числа.");
Console.WriteLine("Введите  число:");
int x = int.Parse(Console.ReadLine()!);
int result = 0;
int x1 = x / 10;
int num = x;
if (x1 >= 10 || x1 <= -10)
{
    while (x > 999 || x < -999)
    {
        x = x / 10;
    }
    if (x < 0)
    {
        x = -x;
        Console.WriteLine($"Третья цыфра числа {num} -> {(x % 10)} ");
    }
    else
    {
        Console.WriteLine($"Третья цыфра числа {num} -> {(x % 10)} ");
    }
}
else
{
    Console.WriteLine($"Число {num} имеет меньше 3х знаков, третьей цыфры нет.");
}