// Программа, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число!");
int num = int.Parse(Console.ReadLine()!);
int x1 = num / 10000;
int x2 = num / 1000 % 10;
int x4 = num / 10 % 10;
int x5 = num % 10; 
if (x1 == x5 && x2 == x4)
{
    Console.WriteLine($"{num} - палиндром!");
}
else
{
    Console.WriteLine("Не палиндром");
}




