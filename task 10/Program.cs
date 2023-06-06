Console.Clear();

int func(string msg)
{
    System.Console.Write(msg);
    string value = Console.Readline();
    int result = Convert.ToInt32(value);
    return result;
}

int number = func("Введите трехзначное число");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Введите трёхзначное число");
    return;
}

Console.WriteLine($"Введённое число {number}");
int chislo = number / 10 % 10;
Console.WriteLine($"Вторая цифра {chislo}");