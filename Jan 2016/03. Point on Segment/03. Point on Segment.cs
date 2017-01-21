using System;
class Program
{
    static void Main(string[] args)
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        double point = double.Parse(Console.ReadLine());
        if (point <= Math.Max(first, second) && point >= Math.Min(first, second))
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
        if (Math.Abs(first - point) >= Math.Abs(second - point))
        {
            Console.WriteLine(Math.Abs(second - point));
        }
        else
        {
            Console.WriteLine(Math.Abs(first - point));         
        }

    }
}

