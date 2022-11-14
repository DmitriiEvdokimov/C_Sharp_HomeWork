// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника


int Factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PascalTriangle()
{
    int i, n, c, core;
    Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
    string s = Console.ReadLine();
    n = Convert.ToInt32(s);


    for (i = 0; i < n; i++)
    {
        for (i = 0; i < n; i++)
            {
                for (c = 0; c <= (n - i); c++) 
                {
                    Console.Write("  "); 
                }
                for (c = 0; c <= i; c++)
                {
                    core = Factorial(i) / (Factorial(c) * Factorial(i - c));//формула вычисления элементов треугольника
                    if (core > 0 && core < 10) Console.Write("   ");
                    if (core >= 10 && core < 100) Console.Write("  ");
                    if (core >= 100 && core < 1000) Console.Write(" ");
                    Console.Write(core); 
                }
                Console.WriteLine();
                Console.WriteLine(); 
            }
    }

}

PascalTriangle();
