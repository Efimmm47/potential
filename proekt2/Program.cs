// Задача 10
Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 || number< -99)
{
    while (number > 999 || number < -999)
{
        number=number%100;
}
    number=number/10;
    number=number%10;
    Console.WriteLine(number);
}
Console.Write("Вторая цифра: " + number);

// Задача 13
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 || num< -99)
{
    while (num > 999 || num < -999)
{
        num=num/10;
}
    num=num% 10;
    Console.WriteLine(num);
}
else Console.WriteLine("Третьего числа нет");

// Задача 15
Console.WriteLine ("Введите число");
int Weekeend = Convert.ToInt32 (Console.ReadLine());
if ( Weekeend % 7  == 0 || (Weekeend + 1) % 7 == 0)  

    Console.WriteLine ("Weekeend!!!");

else 
Console.WriteLine("don't weekeend:( ");