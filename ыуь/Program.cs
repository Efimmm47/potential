// 47
double[,] CreateRandomArray(int rows, int columns, int start, int end)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round((new Random().NextDouble() * (end - start) + start), 1);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = CreateRandomArray(rows, columns, -20, 20);
PrintArray(array);

// 50
int[,] GetRandomArray(int rows, int columns, int start, int end)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetRandomArray(5, 6, 0, 10);
PrintArray(array);

Console.WriteLine("Введите позицию элемента: ");
int number = int.Parse(Console.ReadLine());

int rows = array.GetLength(0);
int columns = array.GetLength(1);

if (number > rows * columns) Console.WriteLine($"{number} -> такого числа в массиве нет.");
else
{
    int position = number - 1;
    int i = position / columns;
    int j = position % columns;
    Console.WriteLine($"Значение элемента в позиции {number} -> {array[i, j]}");
}

//52
int[,] GetRandomArray(int rows, int columns, int start, int end)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = 3;
int cols = 4;
int[,] array = GetRandomArray(rows, cols, 0, 9);
PrintArray(array);

double[] average = new double[cols];
for (int j =0; j < cols; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    average[j] = Math.Round(((double)sum/rows), 1);
}

Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", average)}");