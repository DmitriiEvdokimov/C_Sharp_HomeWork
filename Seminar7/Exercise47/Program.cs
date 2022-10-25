// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] fillArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        array[new Random().Next(0,rows),new Random().Next(0,columns)] *= -1;
    }
    return array;
}

void PrintBinaryDoubleArray(double[,] inArray)
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



Console.Clear();
Console.WriteLine("Задать двумерный массив размером,заполненный случайными вещественными числами");
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

double[,] userArray = fillArray(row, col);
PrintBinaryDoubleArray(userArray);