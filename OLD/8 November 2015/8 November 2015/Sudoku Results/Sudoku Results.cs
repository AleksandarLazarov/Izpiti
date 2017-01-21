using System;
class Program
{
    static void Main(string[] args)
    {
        string chas = Console.ReadLine();
        string medal = "";
        double vreme = 0;
        int broiIgri = 1;
        while (chas!="Quit")
        {
            string chasove = chas.Substring(0, 2);
            string minuti = chas.Substring(3, 2);

            vreme += 60 * int.Parse(chasove) + int.Parse(minuti);
            chas = Console.ReadLine();
            broiIgri++;
        }

        if (broiIgri > 1)
        {
            broiIgri--;
        }

        double avrVreme = vreme / broiIgri;

        if (avrVreme<=720)
        {
            medal = "Gold ";
        }
        else if(avrVreme<=1440)
        {
            medal = "Silver ";
        }
        else if (avrVreme > 1440)
        {
            medal = "Bronze ";
        }

        avrVreme = Math.Ceiling(avrVreme);

        Console.WriteLine("{0}Star",medal);
        Console.WriteLine($"Games - {broiIgri} \\ Average seconds - {avrVreme}");
    }
}

