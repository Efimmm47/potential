
// задача 8
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= a; i += 2)
    if (a % 2 == 0)
        Console.WriteLine(i);
