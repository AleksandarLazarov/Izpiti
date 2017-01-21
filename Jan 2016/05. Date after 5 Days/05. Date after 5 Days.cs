using System;

public class Program
{
    public static void Main()
    {
        int den = int.Parse(Console.ReadLine());
        int mesec = int.Parse(Console.ReadLine());
        DateTime now = new DateTime(2015, mesec, den);

        now = now.AddDays(5);

        string format = "d.MM";   // Use this format.
        Console.WriteLine(now.ToString(format));

    }
}