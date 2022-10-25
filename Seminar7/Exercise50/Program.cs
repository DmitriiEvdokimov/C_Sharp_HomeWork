// Задача 50. Напишите программу, которая на вход принимает число 
// и возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetBinaryArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintBinaryArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int[] FindNubmersBinaryArray(int[,] userArray, int numberToFind)
{
    int[] result = {-1,-1};
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            if (userArray[i, j] == numberToFind)
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
Console.Write($"{numberToFind} -> такого числа в массиве нет");
return result;
}

void PrintArray(int[] col)
{
    if (col[0] != -1)
    {
         Console.WriteLine($"Позиция искомого элемента:[{String.Join(" ,",col)}]");
    }
}

Console.Clear();
Console.WriteLine("Установить индексы элемента в двумерном массиве.");
Console.WriteLine();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомый элемент:");
int find = int.Parse(Console.ReadLine()!);

int[,] userArray = GetBinaryArray(row, col, 0, 10);
PrintBinaryArray(userArray);
Console.WriteLine();
int[] resultArray = FindNubmersBinaryArray(userArray,find);
PrintArray(resultArray);
