// Напишите прогр, кот принимает на вход координаты
// точек (X и Y), причем X != 0 и Y != 0 и выдаёт номер
// четверти плоскости точки 1 - с права верха против часовой

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Quaters(int x, int y)
{
    string result = "";
    if(x > 0 && y > 0)
    {
        result = "1 quater";
    }
    else if(x < 0 && y > 0)
    {
        result = "2 quater";
    }
    else if(x < 0 && y < 0)
    {
        result = "3 quater";
    }
    else if(x > 0 && y < 0)
    {
        result = "4 quater";
    }
    else
    {
        result = "Point on axis";
    }
    return result;
}


int X = Prompt("Введите Х координату ->");
int Y = Prompt("Введите Y координату ->");

string quater = Quaters(X, Y);
Console.WriteLine(quater);

// Sem3 01`16``

// Возведение в степень в данном случае в квадрат
// double number = 5;
// double result = Math.Pow(number. 2);
// Console.WriteLine(result)

// Функция округдения  2 - это до какой цифры округляем
// double number = 5.323454556424542;
// double result1 = Math.Round(number, 2);
// Console.WriteLine(result1

// Можно комбиннировать функции
// double result = Math.Round(Math.Pow(number, 2));
// Console.WriteLine(result)

// Функция извлечения КВАДРАТНОГО корня МОЖНО КОБНИНИРОВАТЬ КАК ВЫШЕ
// double result = Math.Sqrt(25);
// Console.WriteLine(result)

// double result = Math.Round(Math.Sqrt(Math.Pow(number, 2)), 2);
