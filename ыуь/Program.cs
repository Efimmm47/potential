// 54
int[,] GetArray(int row, int column, int start, int end)
{
    int[,] result = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
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

int rows = 6;
int columns = 5;
int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);

int temp;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns - 1; j++)
    {
        for (int k = j + 1; k < columns; k++)
        {
            if (array[i, j] < array[i, k])
            {
                temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(array);

//56
int[,] GetArray(int row, int column, int start, int end)
{
    int[,] result = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
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

int rows = 6;
int columns = 5;
int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);

int temp;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns - 1; j++)
    {
        for (int k = j + 1; k < columns; k++)
        {
            if (array[i, j] < array[i, k])
            {
                temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(array);

//58
int[,] GetArray(int row, int column, int start, int end)
{
    int[,] result = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
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

int rows = 6;
int columns = 5;
int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);

int temp;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns - 1; j++)
    {
        for (int k = j + 1; k < columns; k++)
        {
            if (array[i, j] < array[i, k])
            {
                temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(array);

// 60
int[,,] GetArray(int row, int col, int tub, int start, int end)
{
    int[,,] result = new int[row, col, tub];
    int[] check = new int[end + 1];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < tub; k++)
            {
                int number;
                do
                {
                    number = new Random().Next(start, end + 1);
                }
                while (check[number] != 0);
                result[i, j, k] = number;
                check[number] = 1;

            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = GetArray(2, 2, 2, 10, 99);

PrintArray(array);

//62
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
int[,] array = new int[4, 4];

int SpiralFillArray(int row, int col, int number, bool direction)
{
    if (col < array.GetLength(1) && row < array.GetLength(0) && col >= 0 && row >= 0 && array[row, col] == 0)
    {
        array[row, col] = number++;
        if (direction == false)
        {
            number = SpiralFillArray(row, col + 1, number, false);
            number = SpiralFillArray(row, col - 1, number, false);
            number = SpiralFillArray(row + 1, col, number, true);
            number = SpiralFillArray(row - 1, col, number, true);
        }
        else
        {
            number = SpiralFillArray(row + 1, col, number, true);
            number = SpiralFillArray(row - 1, col, number, true);
            number = SpiralFillArray(row, col + 1, number, false);            
            number = SpiralFillArray(row, col - 1, number, false);            
        }
    }
    return number;
}

SpiralFillArray(0, 0, 1, false);  
PrintArray(array);