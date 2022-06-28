// See https://aka.ms/new-console-template for more information

int x = GetNumber("Введите первое число");

int GetNumber(string text)
{
    Console.WriteLine(text);
    string str = Console.ReadLine();
    return int.Parse(str);
}

int y = GetNumber("Введите второе число");

Console.WriteLine("Пожалуйста выберите команду : +, -, *, /, max, min ");
string cmd = Console.ReadLine();

int result = GetResult(x, y, cmd);

Console.Write(result);

int GetResult(int x, int y, string? cmd)
{
    int result;
    switch (cmd)
    {
        case "+":
            result = x + y;
            break;
        case "-":
            result = x - y;
            break;
        case "*":
            result = x * y;
            break;
        case "/":
            result = x / y;
            break;

        default:
            result = 0;
            break;
    }

    return result;
}
static int GetMax(int x, int y)
{
    int max = 0;
    if (x > y)
        max = x;
    else
        max = y;
    return max;
}

static int GetMin(int x, int y)
{
    int min = 0;
    if (x < y)
        min = x;
    else
        min = y;
    return min;
}