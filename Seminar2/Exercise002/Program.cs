//Задача 15: Напишите программу,
//которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();
Console.WriteLine("Является ли день недели выходным?");
Console.WriteLine("ПН->1");
Console.WriteLine("ВТ->2");
Console.WriteLine("СР->3");
Console.WriteLine("ЧТ->4");
Console.WriteLine("ПТ->5");
Console.WriteLine("СБ->6");
Console.WriteLine("ВС->7");
Console.WriteLine("Введите цифру обозначающую день недели:");
int x = int.Parse(Console.ReadLine()!);
if (x > 0 & x < 6)
{
    Console.WriteLine("Нет, это будний день.");
}
else if (x > 5 & x < 8)
{
    Console.WriteLine("Да, это выходной день.");
}
else
{
    Console.WriteLine("Введите число соотвутствующее дню недели");
}
