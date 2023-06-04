void Random2DArray(int[,] arg, int min, int max)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintMid(int[,] arg)
{
    double sum = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arg.GetLength(1); j++)
        {   
            sum += arg[i, j];
        }
        Console.Write($"{sum / arg.GetLength(1)}; ");
    }

}
int[,] array = new int[3,4];
Random2DArray(array,1,9);
Print2DArray(array);

PrintMid(array);
