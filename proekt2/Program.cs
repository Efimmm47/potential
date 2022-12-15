// задача 2
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
    max = a;
else
    max = b;
Console.WriteLine("Максимальное число равно " + max);

// задача 4
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
    max = a;
else
    max = b;
if (max < c)
    max = c;
Console.WriteLine("Максимальное число равно " + max);

// задача 6
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.WriteLine("четное");
else
    Console.WriteLine("не четное");

// задача 8
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= a; i += 2)
    if (a % 2 == 0)
        Console.WriteLine(i);
