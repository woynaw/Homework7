double[,] Random2DArray(int m, int n)
{
    double[,] array = new double[m,n];
    double rangeMin = -9;
    double rangeMax = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            array[i, j] = rangeMin + (rangeMax - rangeMin) * random.NextDouble();
        }
    }
    return array;
}
void Print2DArray(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(arg[i, j],1)} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = Random2DArray(m,n);
Print2DArray(array);