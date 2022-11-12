// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] ArrayOfSum(int[,] userMatrix)
{
    int rows = userMatrix.GetLength(0);
    int eachSum = 0;
    int[] sums = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < userMatrix.GetLength(1); j++)
        {
            eachSum += userMatrix[i, j];
        }
        sums[i] = eachSum;
        eachSum = 0;
    }
    return sums;
}

void NumberOfMinRow(int[] sumOfRows)
{
    int min = sumOfRows[0];
    int position = 0;
    for (int i = 1; i < sumOfRows.Length; i++)
    {
        if (min > sumOfRows[i]) 
        {
            min = sumOfRows[i];
            position = i;   
        } 
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов в строке {position + 1}");
    Console.WriteLine();
}

int[] toFindMin = ArrayOfSum(GetBinaryArray());
NumberOfMinRow(toFindMin);



