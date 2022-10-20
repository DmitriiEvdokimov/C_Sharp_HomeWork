// Задача "со звездочкой": Разобраться с алгоритмом сортировки
// методом пузырька. Реализовать невозрастающую сторировку.


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
int[] BubbleSort(int[] collection)
{

    for (int i = 0; i < collection.Length; i++)
    {
        bool flag = true;
        for (int j = 0; j < collection.Length - (i+1); j++)
        {
            if (collection[j] < collection[j+1])
            {
                flag = false;
                int temp = collection[j];
                collection[j] = collection[j+1];
                collection[j+1] = temp;
            }
        }
        if (flag) break;
    }
    return collection;
}


Console.Clear();
Console.WriteLine("Реализовать невозрастающую сторировку.");
Console.WriteLine("Случайный массив:");
int[] numbers = fillArray(10, 1, 99);
PrintArray(numbers);
int[] numbersSort = BubbleSort(numbers);
Console.WriteLine("Массив после сортировки:");
PrintArray(numbersSort);




