Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] CreateArray (int n, int m)
{
    return new int [n, m];
}

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        } Console.WriteLine();
    }
}


void AverageSum (int [,] array, int row, int column)
{
    double [] ArraySum = new double [column];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            ArraySum[j] = ArraySum[j] + array [i, j];
        }
    }

    for (int i = 0; i < column; i++)
    {
        Console.WriteLine($"Среднеарифметическое значение столбца {i+1} равно {Math.Round(ArraySum[i]/ row), 3}"); // Пользовательский вид вывода, счёт с 1
    }
}


int [,] arr = CreateArray (row, column);
FillArray (arr);
PrintArray (arr);
Console.WriteLine();
AverageSum (arr, row, column);