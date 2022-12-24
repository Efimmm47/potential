// Задача 19
Console.WriteLine("введите пятизначное число которое вы хотите проверить на палиндром");
string polin = Console.ReadLine();
int kolvo = polin.Length;

if (kolvo == 5) 
{
    if (polin[0] == polin[4] && polin[1] == polin[3]) 
    {
        Console.WriteLine(polin +"- число является палиндромом");
    }
    else
    {
        Console.WriteLine(polin +" - число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Ошибка!!!");
}

//Задача 21
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = ReadInt("Введите координату X1 первой точки: ");
int y1 = ReadInt("Введите координату Y1 первой точки: ");
int z1 = ReadInt("Введите координату Z1 первой точки: ");
int x2 = ReadInt("Введите координату X2 второй точки: ");
int y2 = ReadInt("Введите координату Y2 второй точки: ");
int z2 = ReadInt("Введите координату Z2 второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

//Задача 23
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}