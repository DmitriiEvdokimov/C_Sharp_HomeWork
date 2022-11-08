// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindMinNumber(int[,] userMatrix)
{
    int[] positionMinNumber = new int[2];
    int minNumber = userMatrix[0, 0];
    for (int i = 0; i < userMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < userMatrix.GetLength(1); j++)
        {
            if (userMatrix[i, j] < minNumber)
            {
                minNumber = userMatrix[i, j];
                positionMinNumber[0] = i;
                positionMinNumber[1] = j;
            }
        }
    }
    Console.WriteLine($"Минимальное число:{minNumber}");
    Console.Write("Позиция:");
    Console.WriteLine($"({String.Join(" ,", positionMinNumber)})");
    return positionMinNumber;
}

int[,] CutArray(int[,] userArray, int[] positionToCut)
{
    int n = 0;
    int m = 0;
    int rows = userArray.GetLength(0);
    int columns = userArray.GetLength(1);
    int[,] result = new int[rows-1, columns-1];
    for (int i = 0; i < rows; i++)
    {
        m = 0;
        for (int j = 0; j < columns; j++)
        {
            if (j != positionToCut[1])
            {
                result[n, m] = userArray[i, j];
                m++;
            }
        }
        if (i != positionToCut[0]) n++;
    }
    return result;
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetBinaryArray(row, col, 0, 100);
PrintBinaryArray(userArray);
int[] minPosition = FindMinNumber(userArray);
int[,] resultMatrix = CutArray(userArray, minPosition);
Console.WriteLine();
PrintBinaryArray(resultMatrix);
