Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] CreateArray (int n, int m)
{
    return new int [n, m];
}

void FillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(-10,10);
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
        } System.Console.WriteLine();
    }
}

void Result (int [,] array, int CustomRow, int CustomColumn)
{
    if (CustomRow <= array.GetLength(0) && CustomColumn<= array.GetLength(1))
    {   
        Console.WriteLine($"Выбранный элемент: {array[CustomRow-1, CustomColumn-1]}");
    }
    else
    {
        Console.WriteLine("По данном адресу нет элемента массива");
    }
      
    
    
}

int[,] arr = CreateArray(row, column);
FillArray (arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine("Укажите строку элемента: ");
int RowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец элемента: ");
int ColumnIndex = Convert.ToInt32(Console.ReadLine());
Result(arr, RowIndex, ColumnIndex);