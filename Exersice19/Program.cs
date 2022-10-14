// Программа, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число!");
int num = int.Parse(Console.ReadLine()!);
int result = num / 10000;
Console.WriteLine($"{result}");



