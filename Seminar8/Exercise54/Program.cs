// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintBinaryArray(int[,] userArray)
{
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            Console.Write($"{userArray[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int[,] GetBinaryArray()
{
    Console.Clear();
    Console.Write("Введите количество строк в массиве:");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов в массиве:");
    int n = int.Parse(Console.ReadLine()!);
    int[,] result = new int[m, n];
    int minValue = 0;
    int maxValue = 10;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    PrintBinaryArray(result);
    return result;
}

void SortEachRowsOfMatrix(int[,] userArray)
{
    int k;
    for (int q = 0; q < userArray.GetLength(0); q++)
    {
        for (int i = 0; i < userArray.GetLength(1); i++)
        {
            for (int j = i + 1; j < userArray.GetLength(1); j++)
            {
                if (userArray[q,i] < userArray[q,j])
                {
                    k = userArray[q,i];
                    userArray[q,i] = userArray[q,j];
                    userArray[q,j] = k;
                }
            }
        }
    }
    PrintBinaryArray(userArray);
}



int[,] matrix = GetBinaryArray();  
Console.WriteLine();
SortEachRowsOfMatrix(matrix);