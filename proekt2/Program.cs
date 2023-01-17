// задача 34
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 100;
int end = 999;
int[] bob = (CreateRandomArray(N,start,end));
int a = 0;
for (int i = 0; i < N; i++)
{
    if (bob[i] % 2 == 0)
    {
        a = a + 1;
    }
     else
     a = a + 0; 
}
Console.WriteLine($"[{String.Join(",", bob)}]");
Console.WriteLine($"[{String.Join(",", a)}]");


// задача 36
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = -50;
int end = 50;
int[] bob = (CreateRandomArray(N,start,end));
int sumotr = 0;
for (int i = 0; i < N; i++)
{
    if (bob[i] % 2 != 0)
    {
        sumotr = sumotr + bob[i];
    }
     else
     sumotr = sumotr + 0; 
}
Console.WriteLine($"[{String.Join(",", bob)}]");
Console.WriteLine($"[{String.Join(",", sumotr)}]");


//задача 38
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(1,100)) ;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");