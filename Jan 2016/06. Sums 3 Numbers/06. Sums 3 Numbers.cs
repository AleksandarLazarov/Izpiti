using System;
public class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a + b == c)
        {
            Console.WriteLine("{0} + {1} = {2}", Math.Min(a, b), Math.Max(a, b), c);
        }
        else if (b + c == a)
        {
            Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(c, b), a);
        }
        else if (c + a == b)
        {
            Console.WriteLine("{0} + {1} = {2}", Math.Min(a, c), Math.Max(a, c), b);
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

