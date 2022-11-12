// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void PrintCubeArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int q = 0; q < inArray.GetLength(2); q++)
            {
                Console.WriteLine($"Значение: {inArray[i, j, q]}, позиция: ({i},{j},{q})");
            }
        }
    }
}

int[,,] GetCubeArray()
{
    Console.Clear();
    Console.Write("Введите количество строк в массиве:");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов в массиве:");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество уровней глубины массива:");
    int k = int.Parse(Console.ReadLine()!);
    int[,,] result = new int[m, n, k];
    int minValue = 0;
    int maxValue = 10;


    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int q = 0; q < k; q++)
            {
                result[i, j, q] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    PrintCubeArray(result);
    return result;
}

GetCubeArray();
