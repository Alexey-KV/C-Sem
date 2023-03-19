// Число N  ->  таблица квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.  2 -> 1, 4.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for( int i = 1; i <= number; i++)//Ex. Цикл через 1: i+=2  <->  i = i + 2
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
}
