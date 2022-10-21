// Задача со звездочкой: Напишите программу, 
// которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9


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
    var n = matrix.GetLength(0);
    var r = new int[n * n];
    int j = -1, i = 0;
    var h = true;
    var d = !h;
    int o = 0;
    int p = n;
    int m = n;
    for (var c = 1; c <= matrix.Length; c++)
    {
        p--;
        r[c - 1] = matrix[h ? i : !d ? ++i : --i, !h ? j : !d ? ++j : --j];
        if (p <= 0 && matrix.Length != 2)
        {
            h = !h;
            if ((o + 1) % 2 == 0) d = !d;
            if (c == n || o > 1 && (o + 1) % 2 != 0) --m;
            p = m;
            o++;
        }
    }
    return r;
}


int[,] userMatrix =
{{1, 2, 3},
{4, 5, 6},
{7, 8, 9}};

PrintMatrix(userMatrix);
int[] result = CountClock(userMatrix);
Console.WriteLine(String.Join(" ,",result));




// int[] ReadMatrix(int row, int col)
// {
//     int[] result = new int[userMatrix.GetLength(0) * userMatrix.GetLength(1)];
//     row = userMatrix.GetLength(0);
//     col = 0;
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = userMatrix[row, col];
//         ReadMatrix(row-1, col);
//         ReadMatrix(row - 1, col);
//         ReadMatrix(row + 1, col);
//         ReadMatrix(row, col + 1);
//     }
//     return result;
// }


// int[] ReadMatrix(int[,] mat)
// {
//     int[] result = new int[mat.GetLength(0) * mat.GetLength(1)];
//     int j = 0;
//     int x = mat.GetLength(0) - 1;
//     int y = 0;
//     int count = 0;
//     for (int i = 0; i < mat.GetLength(1); i++)
//     {
//         result[j] = mat[x, y];
//         y++;
//         j++;
//     }
//     count++;
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         result[j] = mat[x - count, y];
//         x--;
//         j++;
//     }
//     return result;
// }


// int[] CountClock(int[,] matrix)
// {
//     int x = 0;
//     int y = matrix.GetLength(1) - 1

//     int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1); i++)
//     {
//         result[i] = matrix[, ];
//         CountClock(matrix);
//     }
//     return result;
// }

