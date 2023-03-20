// Напиште программу, кот выводит массив из 8 эл-тов
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,1,0,1,1]

Console.Write("Введите кол-во эл-тов массиваЖ ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,2);
    Console.Write($"{arr[i]} ");
}

// "Красивые" методы вывода:
// Console.Writline('[' + string.Join(", ", arr) + "]");
// Console.WriteLine($"[{string.Join("; ", arr)}]");

// Random rnd = new Random();
// соотв
// вместо arr[i] = rnd.Next(0,2); //см выше
