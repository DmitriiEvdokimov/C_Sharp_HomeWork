// Задача со звездочкой: Напишите программу, 
// которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

int[,] Fillmatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 100);
        }
    }
    return matr;
}

void PrintMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}





int[] CountClock(int[,] matrix)
{
    var rows = matrix.GetLength(0);
    var result = new int[rows * rows];
    int j = -1, i = 0;
    var h = true;
    var d = !h;
    int o = 0;
    int p = rows;
    int columns = rows;
    for (var c = 1; c <= matrix.Length; c++)
    {
        p--;
        result[c - 1] = matrix[h ? i : !d ? ++i : --i, !h ? j : !d ? ++j : --j];
        if (p <= 0 && matrix.Length != 2)
        {
            h = !h;
            if ((o + 1) % 2 == 0) d = !d;
            if (c == rows || o > 1 && (o + 1) % 2 != 0) --columns;
            p = columns;
            o++;
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int b = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[a, b];
matrix = Fillmatrix(matrix);
PrintMatrix(matrix);
int[] array = CountClock(matrix);
Console.WriteLine("______________________________________");
Console.WriteLine(String.Join(" ,",array));