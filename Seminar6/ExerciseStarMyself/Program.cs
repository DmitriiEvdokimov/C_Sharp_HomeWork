// Задача со звездочкой: Напишите программу, 
// которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9


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

int[] CounterClockArray(int[,] matrix)
{
    int count = 0;
    int x = matrix.GetLength(0) - 1;
    int y = 0;
    int n = 0;
    int[] finalArray = new int[matrix.Length];
    for (int i = 0; i < matrix.Length; i++)

    {
        while (y < matrix.GetLength(1) - count && n < matrix.Length)
        {
            finalArray[n++] = matrix[x, y];
            y++;
        }
        x--;
        y--;
        while (x > 0 + count && n < matrix.Length)
        {
            finalArray[n++] = matrix[x, y];
            x--;
        }
        while (y >= 0 + count && n < matrix.Length)
        {
            finalArray[n++] = matrix[x, y];
            y--;
        }
        x++;
        y++;
        count++;
        while (x < matrix.GetLength(0) - count && n < matrix.Length)
        {
            finalArray[n++] = matrix[x, y];
            x++;
        }
        x--;
        y++;
    }
    return finalArray;
}


Console.Clear();
Console.Write("Обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.");
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetBinaryArray(row, col, 1, 100);
PrintBinaryArray(userArray);
Console.WriteLine("____________________");
int[] endArray = CounterClockArray(userArray);
Console.WriteLine(String.Join(" ,", endArray));
