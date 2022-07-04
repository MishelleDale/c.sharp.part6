double [,] CreateArray (int n, int m)
{
    return new double [n, m];
}

void FillArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = (new Random().NextDouble()) * (new Random().Next(-10, 11));
        } 
    }
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        } Console.WriteLine();
    }
}

Console.WriteLine("Введите высоту массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива");
int column = Convert.ToInt32(Console.ReadLine());

double[,] arr = CreateArray(row, column);
FillArray(arr);
PrintArray(arr);