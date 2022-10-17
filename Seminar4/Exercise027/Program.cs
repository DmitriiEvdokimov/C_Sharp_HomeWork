// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


string NumToString(int num)
    {
    string s1 = num.ToString();
    return s1;
    }

int StringToSum(string str)
{
    int sum = 0;
    for (int i = 0; i < str.Length; i++)
    {

        int number = Convert.ToInt32(new string(str[i],1));
        sum = sum + number;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Сумма цифр в числе.");
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
string digits = NumToString(number);
int result = StringToSum(digits);

Console.WriteLine($"Сумма цифр в числе {number} равна {result}");
