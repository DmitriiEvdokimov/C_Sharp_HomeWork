// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

string StringBuilder(string text, int index, char replacement = '*')
{
    text = text.Remove(index, 1).Insert(index, replacement.ToString());
    return text;
}


bool OrderOfBracketCheckRec(string userText)
{
    for (int i = 0; i < userText.Length; i++)
    {
        if (userText[i] == ')')
        {
            for (int j = i - 1; j >= 0; j--)
            {

                if (userText[j] == '(')
                {
                    userText = StringBuilder(userText, i);
                    userText = StringBuilder(userText, j);
                    OrderOfBracketCheckRec(userText);
                    break;
                }
                if (userText[j] == '{') return false;
                if (userText[j] == '[') return false;
            }
        }
        if (userText[i] == '}')
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (userText[j] == '{')
                {
                    userText = StringBuilder(userText, i);
                    userText = StringBuilder(userText, j);
                    OrderOfBracketCheckRec(userText);
                    break;
                }
                if (userText[j] == '(') return false;
                if (userText[j] == '[') return false;
            }
        }
        if (userText[i] == ']')
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (userText[j] == '[')
                {
                    userText = StringBuilder(userText, i);
                    userText = StringBuilder(userText, j);
                    OrderOfBracketCheckRec(userText);
                    break;
                }
                if (userText[j] == '(') return false;
                if (userText[j] == '{') return false;
            }
        }
    }
    foreach (var item in userText)
    {
        if (item == '(' || item == ')'
          || item == '{'|| item == '}'
          || item == '['|| item == ']') return false;
    }
    return true;
}


Console.WriteLine("Введите последовательность скобок");
string text = Console.ReadLine();
Console.WriteLine();
if (OrderOfBracketCheckRec(text)) Console.WriteLine("Последователность верна");
else Console.WriteLine("Последовательность не верна");
Console.WriteLine();

