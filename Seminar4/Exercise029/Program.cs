// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

string[] CreateArray(string x1, string x2, string x3, string x4,
                    string x5, string x6, string x7, string x8)
{
    string[] array = new string[8] { x1, x2, x3, x4, x5, x6, x7, x8 };
    return array;
}

void PrintArray(string[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]);
        if (i < numbers.Length - 1 && (!(String.IsNullOrEmpty(numbers[i]))))
        {
            {
                Console.Write(", ");
            }
        }
    }
    Console.Write("]");
}

Console.Clear();
Console.WriteLine("Задать массив из 8 элементов и вывести его на экран.");

Console.WriteLine("Введите первый элемент:");
string? num1 = Console.ReadLine();
Console.WriteLine("Введите второй элемент:");
string? num2 = Console.ReadLine();
Console.WriteLine("Введите третий элемент:");
string? num3 = Console.ReadLine();
Console.WriteLine("Введите четверый элемент:");
string? num4 = Console.ReadLine();
Console.WriteLine("Введите пятый элемент:");
string? num5 = Console.ReadLine();
Console.WriteLine("Введите шестой элемент:");
string? num6 = Console.ReadLine();
Console.WriteLine("Введите седьмой элемент:");
string? num7 = Console.ReadLine();
Console.WriteLine("Введите восьмой элемент:");
string? num8 = Console.ReadLine();

string[] userArray = CreateArray(num1, num2, num3, num4, num5, num6, num7, num8);

PrintArray(userArray);
