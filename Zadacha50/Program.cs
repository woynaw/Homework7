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

void PrintElement(int[,] arg, int m , int n)
{
    if (m <= arg.GetLength(0) && n <= arg.GetLength(1)) Console.WriteLine($"{m} {n} -> {arg[m-1, n-1]} ");
    else Console.WriteLine($"{m} {n} -> Такого числа в массиве нет");

}
int[,] array = new int[3,4];
Random2DArray(array,1,9);
Print2DArray(array);
Console.WriteLine("Введите строку");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int n = Convert.ToInt32(Console.ReadLine());
PrintElement(array,m,n);
