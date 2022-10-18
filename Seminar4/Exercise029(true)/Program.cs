// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

string CorrectText(string text)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == '0' || text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' ||
        text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9' || text[i] == ',')
        {
            result = result + text[i];
        }
    }
    return result;
}
int[] CreateArray(string NewText)
{
    int[] argArray = new int[8];

    int i = 0;
    string arg = String.Empty;
    int index = 0;
    while (index < 8 && i < NewText.Length)
    {
        while (NewText[i] != ',' && i < NewText.Length)
        {
            arg = arg + NewText[i];
            i++;
            if (i == NewText.Length) break;
        }
        if (!(String.IsNullOrEmpty(arg)))
        {
            argArray[index] = Convert.ToInt32(arg);
        }
        index++;
        i++;
        arg = String.Empty;

    }
    return argArray;
}
int[] CutArray(int[] longArray)
{
    int count = 0;
    for (int i = 0; i < longArray.Length; i++)
    {
        if (longArray[i] != 0)
        {
            count = count +1;
        }
    }
    int[] shortArray = new int [count];
    int j=0;
    for (int i = 0; i < longArray.Length; i++)
    {
        if (longArray[i] != 0)
        {
            shortArray[j] = longArray[i];
            j++;
        }
    }

    return shortArray;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.Clear();
Console.WriteLine("Создать массив");
Console.WriteLine("Введите числа массива через запятую:");
string? text1 = Console.ReadLine();
string NewText = CorrectText(text1);
int[] prefinalArray = CreateArray(NewText);
int[] finalArray = CutArray(prefinalArray);
PrintArray(finalArray);

//Console.WriteLine(NewText);







