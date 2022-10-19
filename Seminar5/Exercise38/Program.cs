// Задача 38: Задайте массив !вещественных! чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = double.Parse(nums[i]);
    }
    return res;
}
void PrintArray(double[] col)
{
    Console.WriteLine(String.Join(" ,", col));
}
double RangeMinMax(double[] collection)
{
    double result = 0;
    double max = collection[0];
    double min = collection[0];
    foreach (double item in collection)
    {
        if (item > max)
        {
            max = item;
        }
        if (item < min)
        {
            min = item;
        }
    }
    Console.WriteLine($"Max = {max}");
    Console.WriteLine($"Min = {min}");
    result = max - min;
    return result;
}


Console.Clear();
Console.WriteLine("Найдём разницу между максимальным и минимальным элементом массива.");
Console.WriteLine("Введите числа массива через пробел:");
string text = Console.ReadLine();
double[] numbers = GetArrayFromString(text);
//PrintArray(numbers);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:{RangeMinMax(numbers)}");