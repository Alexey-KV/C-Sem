// Программа должна вывести случайное трехзначное число 
// и удалить вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt ("Введите трёхзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"Введённое число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine ($"Вторая цифра `{secondRank}`");
