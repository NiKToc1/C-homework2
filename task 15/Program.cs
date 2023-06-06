Console.Clear();

int func(string msg)
{
    System.Console.Write(msg);
    string value = Console.Readline();
    int result = Convert.ToInt32(value);
    return result;
}

bool WeekEndCheck(int day);
{
    if(day > 5)
    {
        return true;
    }
    return false;
}

bool daycheck(int number)
{
    if(number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Неправильный день недели");
    return false;
}

int day = func("Введите день недели");
if(daycheck(day));
{
    if(WeekEndCheck(day))
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}