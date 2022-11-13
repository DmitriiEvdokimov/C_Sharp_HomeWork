// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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

int[,] GetBinarySpiralArray()
{
    Console.Clear();
    Console.Write("Введите количество строк в массиве:");
    int hight = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов в массиве:");
    int wide = int.Parse(Console.ReadLine()!);
    int[,] result = new int[hight, wide];
    int total = hight * wide;
    int x = 0;
    int y = 0;
    int count = 0;
    int curentNumber = 1;
    PrintBinaryArray(result);
    Console.WriteLine();

    for (int i = 0; i < total; i++)
    {
        while (y < wide - count && curentNumber <= total)
        {
            result[x, y] = curentNumber++;
            y++;
        }
        x++;
        y--;
        while (x < hight - count && curentNumber <= total)
        {
            result[x, y] = curentNumber++;
            x++;
        }
        x--;
        y--;
        while (y >= 0 + count && curentNumber <= total)
        {
            
            result[x, y] = curentNumber++;
            y--;
        }
        x--;
        y++;
        count++;
        while (x >= 0 + count && curentNumber <= total)
        {
            result[x, y] = curentNumber++;
            x--;
        }
        x++;
        y++;
    }

    PrintBinaryArray(result);
    return result;
}

GetBinarySpiralArray();



