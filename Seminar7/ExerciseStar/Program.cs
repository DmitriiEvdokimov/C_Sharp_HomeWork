// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994
int RomeDigits(string romeNumber)
{
    int[] convert = new int[romeNumber.Length + 1];
    int result = 0;
    for (int i = 0; i < romeNumber.Length; i++)
    {
        if (romeNumber[i] == 'I') convert[i] = 1;
        else if (romeNumber[i] == 'V') convert[i] = 5;
        else if (romeNumber[i] == 'X') convert[i] = 10;
        else if (romeNumber[i] == 'L') convert[i] = 50;
        else if (romeNumber[i] == 'C') convert[i] = 100;
        else if (romeNumber[i] == 'D') convert[i] = 500;
        else if (romeNumber[i] == 'M') convert[i] = 1000;
    }
    if (convert.Length >= 3)
    {
        for (int i = 0; i < convert.Length - 1; i++)
        {
            if ((convert[i] == convert[i + 1]) && (convert[i] == 5 || convert[i] == 50 || convert[i] == 500))
            {
                Console.WriteLine("Цифры V, L, D не могут повторяться");
                return result;
            }
        }
    }
    if (convert.Length >= 4)
    {
        for (int i = 0; i < convert.Length - 2; i++)
        {
            if (convert[i] < convert[i + 2])
            {
                Console.WriteLine("Двойное вычитание недопустимо");
                return result;
            }
        }
    }
    if (convert.Length >= 5)
    {
        for (int i = 0; i < convert.Length - 2; i++)
            if (convert[i] == convert[i + 1] && convert[i] == convert[i + 2] && convert[i] == convert[i + 3])
            {
                Console.WriteLine("Цифры I, X, C, M могут повторяться не более трех раз подряд");
                return result;
            }
    }
    int j = 0;
    while (j < convert.Length)
    {
        if (convert[j] == 0)
        {
            return result;
        }
        else if (convert[j + 1] == 0)
        {
            result += convert[j];
            return result;
        }
        else if (convert[j] >= convert[j + 1])
        {
            result += convert[j];
            j++;
        }
        else
        {
            result += convert[j + 1] - convert[j];
            if (convert[j] == 5 || convert[j] == 50 || convert[j] == 50)
            {
                result = 0;
                Console.WriteLine("Вычитаться могут только числа, обозначающие 1 или степени 10");
                return result;
            }
            if (convert[j + 1] / convert[j] > 10)
            {
                Console.WriteLine("Уменьшаемым может быть только цифра, ближайшая в числовом ряду к вычитаемой");
                Console.WriteLine("IV = 5 - 1 = 4; IX = 10 - 1 = 9; XL = 50 - 10 = 40; XC = 100 - 10 = 90");
                result = 0;
                return result;
            }
            j += 2;
        }
    }
    return result;
}



Console.Clear();
Console.WriteLine("Перевод римских чисел в десятичные арабские (до 3 999)");
Console.WriteLine("Введите число римскими цифрами для конвертаци:");
string userRomeNumber = Console.ReadLine()!;
int result = RomeDigits(userRomeNumber);
if (result != 0)
{
    Console.WriteLine($"Число {userRomeNumber} арабскими цифрами пишется: {result}");
}
else Console.WriteLine("Введите число корректно");
