//64
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

string Numbers(int n)
{
    if (n >= 1) return $"{n} " + Numbers(n - 1);
    else return String.Empty;
}
Console.WriteLine(Numbers(n));


//66
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

int Sum(int m, int n)
{
    if (m > n) return n + Sum(m, n + 1);
    else if (m < n) return m + Sum(m + 1, n);
    return m;
}

Console.WriteLine(Sum(m, n));


//68
int Ackerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ackerman(n - 1, 1);
    else return Ackerman(n - 1, Ackerman(n, m - 1));
}
int n = 2;
int m = 3;
Ackerman(n, m);

Console.WriteLine($"n = {n}, m = {m} -> A({n}, {m}) = {Ackerman(n, m)}");