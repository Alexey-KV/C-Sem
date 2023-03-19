// Рассчитать расстояние медлу точками в двумерном промтранстве
// A (3, 6); B (2, 1) -> 5,09, A (7, -5); B (1, -1) -> 7,21

double Distance2D(double ax, double ay, double bx, double by)
{
    double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    return Math.Round(distance, 2);
}

Console.Write("Введите координату X точки A: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double By = Convert.ToDouble(Console.ReadLine());

double result = Distance2D(Ax, Ay, Bx, By);
Console.WriteLine(result);


