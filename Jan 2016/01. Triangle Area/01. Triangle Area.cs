using System;
class Program
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        double lice = Math.Abs(x2 - x3) * Math.Abs(y1 - y2) / 2;
        Console.WriteLine(lice);

    }
}

