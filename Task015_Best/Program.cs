// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным. 6 - да, 7 - да, 1 - нет.

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool CorrectWeekdayNumber(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    Console.WriteLine("It`s not a week day number");
    return false;
}

int weekDay = Prompt ("Enter a day number >");
if  (CorrectWeekdayNumber(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Weekend");
    }
    else
    {
        Console.WriteLine("Weekday");
    }
}
