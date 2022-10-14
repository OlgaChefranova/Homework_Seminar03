// //Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите X координаты точки А");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки А");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки А");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координаты точки В");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки В");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки В");
int z2 = int.Parse(Console.ReadLine()!);

double Dist(int x1,int y1,int z1,int x2,int y2,int z2);
{
    double result;
    result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return result;
}
    Console.Write($"Длина отрезка АВ равна : {Dist(x1,y1,z1,x2,y2,z2):f2}");