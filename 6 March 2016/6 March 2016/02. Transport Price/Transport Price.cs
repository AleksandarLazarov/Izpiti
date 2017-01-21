using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string vreme = Console.ReadLine().ToLower();
        decimal suma = 0;

        if (vreme == "day")
        {
            if (n >= 100)
            {
                suma = n * 0.06m;
            }
            else if (n >= 20)
            {
                suma = n * 0.09m;
            }
            else
            {
                suma = n * 0.79m + 0.70m;
            }
        }
        else
        {
            if (n >= 100)
            {
                suma = n * 0.06m;
            }
            else if (n >= 20)
            {
                suma = n * 0.09m;
            }
            else
            {
                suma = n * 0.90m + 0.70m;
            }
        }

        Console.WriteLine("{0}",suma);

    }
}

