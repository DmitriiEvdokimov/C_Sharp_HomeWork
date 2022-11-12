// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationOfMatrix(int[,] matrixA, int[,] matrixB)
{
    int hightA = matrixA.GetLength(0);
    int wideA = matrixA.GetLength(1);
    int hightB = matrixB.GetLength(0);
    int wideB = matrixB.GetLength(1);
    int[,] result = new int[hightA, wideB];
    if (wideA != hightB)
    {
        Console.WriteLine("Чтобы можно было умножить две матрицы,");
        Console.WriteLine("количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
        Console.WriteLine("Перемножить матрицы невозможно.");
        return result;
    }
    for (int q = 0; q < hightA; q++)
    {
        for (int k = 0; k < wideB; k++)
        {
            for (int j = 0; j < wideA; j++)
            {
                result[q, k] += matrixA[q, j] * matrixB[j, k];
            }
        }
    }
    PrintBinaryArray(result);
    return result;
}


int[,] userMatrixA = GetBinaryArray();
Console.WriteLine();
int[,] userMatrixB = GetBinaryArray();
Console.WriteLine();
Console.WriteLine("Результат умножения матриц:");
Console.WriteLine();
int[,] resultMatrix = MultiplicationOfMatrix(userMatrixA, userMatrixB);
