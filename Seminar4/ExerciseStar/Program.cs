// Задача “со звездочкой”: Напишите функцию,
//  которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.


void Drawing(int top)
{
    Console.Clear();
    int x = top;
    int y = 0;
    int count = 1;
    while (y < top)
    {
        while (x < count+top)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
            x++;
        }
        x = top;
        x = x - count;
        count = count + 1;
        y++;
    }

}



Console.Clear();
Console.WriteLine("Нарисовать ёлочку.");
Console.WriteLine("Введите высоту ёлочки:");
int height = int.Parse(Console.ReadLine()!);
Drawing(height);
