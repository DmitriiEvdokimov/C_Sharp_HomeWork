// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена



bool OrderOfBracketCheck(string userText)
{
    string stack = string.Empty;
    int top = -1;
    for (int i = 0; i < userText.Length; i++)
    {

        if (userText[i] == '(')
        {
            stack += '(';
            top++;
        }
        else if (userText[i] == '{')
        {
            stack += '{';
            top++;
        }
        else if (userText[i] == '[')
        {
            stack += '[';
            top++;
        }

        else if (userText[i] == ')' && stack == string.Empty) return false;
        else if (userText[i] == '}' && stack == string.Empty) return false;
        else if (userText[i] == ']' && stack == string.Empty) return false;

        else if (userText[i] == ')')
        {
            if (stack[top] == '(') stack = stack.Remove(top--);
            else return false;
        }
        else if (userText[i] == '}')
        {
            if (stack[top] == '{') stack = stack.Remove(top--);
            else return false;
        }
        else if (userText[i] == ']')
        {
            if (stack[top] == '[') stack = stack.Remove(top--);
            else return false;
        }
    }
    if (stack == string.Empty) return true;
    else return false;
}

Console.WriteLine("Введите последовательность скобок");
string text = Console.ReadLine();
Console.WriteLine();
if (OrderOfBracketCheck(text)) Console.WriteLine("Последователность верна");
else Console.WriteLine("Последовательность не верна");
Console.WriteLine();


