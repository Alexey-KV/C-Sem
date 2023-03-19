// Напишите программу, кот по зад номеру четверти,
// показ диапазон координат точек в этой четверти

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Checked(int quater)
{
    if(quater >= 1 && quater <= 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string[] quaters = {"x > 0; y > 0", "x < 0; y > 0", "x<0; y<0", "x>0; y<0"};

int quater = Prompt("Please input quater ->");

if(Checked(quater))
{
    Console.Write(quaters[quater - 1]);
}
else
{
    Console.Write("Wrong number");
}
