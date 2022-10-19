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

    for (int n = 0; n < collection.Length - 1; n++)
    {
        int j = 1;
        int temp = 0;
        for (int i = 0; i < collection.Length - 1; i++)
        {
            if (collection[i] < collection[j])
            {
                temp = collection[i];
                collection[i] = collection[j];
                collection[j] = temp;
            }

            j++;
        }
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




