// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число (A): ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число (B): ");
int numB = Convert.ToInt32(Console.ReadLine());
int remainder = 0;

remainder = numA % numB;

if (remainder == 0)
{
    Console.Write("Число B кратно числу A");
}
else
{
    Console.Write($"Число B не кратно числу A, остаток равен: {remainder}");
}
