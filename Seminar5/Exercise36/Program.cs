// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] fillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] col)
{
    Console.WriteLine(String.Join(" ,", col));
}
int CountPosition(int[] collection)
{
    int sum = 0;
    for (int i = 1; i < collection.Length; i = i + 2)
    {
        sum = sum + collection[i];
    }
    return sum;
}


Console.Clear();
Console.WriteLine("Найти сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Случайный массив");
int[] numbers = fillArray(10, 1, 99);
PrintArray(numbers);
Console.WriteLine($"Сумма элементов равна {CountPosition(numbers)}");