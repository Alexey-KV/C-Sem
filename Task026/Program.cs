// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Counter(int number)
{
    int counter = 0;
    if(number ==0)
    {
        counter = 1;
    }
    while (number > 0)
    {
        number/=10;
        counter++;
    }
    return counter;
}

Console.Write("Enter the number: ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write($"Digits number is = {Counter(A)}");
