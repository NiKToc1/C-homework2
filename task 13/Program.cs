Console.Clear();

int func(string msg)
{
    System.Console.Write(msg);
    string value = Console.Readline();
    int result = Convert.ToInt32(value);
    return result;
}

int thirdnumber(int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool check(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = func("Введите число");
if(check(number))
{
    Console.WriteLine(thirdnumber(number));
}