using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;
        double n1 = 0;
        double n2 = 0;
        double n3 = 0;
        double n4 = 0;
        double n5 = 0;


        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 200)
            {
                n1++;
            }
            else if (num >= 200 && num < 400)
            {
                n2++;
            }
            else if (num >= 400 && num < 600)
            {
                n3++;
            }
            else if (num >= 600 && num < 800)
            {
                n4++;
            }
            else if (num >= 800 && num <= 1000)
            {
                n5++;
            }
        }

        p1 = n1 / n * 100;
        p2 = n2 / n * 100;
        p3 = n3 / n * 100;
        p4 = n4 / n * 100;
        p5 = n5 / n * 100;
        Console.WriteLine("{0:0.00}%", p1);
        Console.WriteLine("{0:0.00}%", p2);
        Console.WriteLine("{0:0.00}%", p3);
        Console.WriteLine("{0:0.00}%", p4);
        Console.WriteLine("{0:0.00}%", p5);

    }
}

