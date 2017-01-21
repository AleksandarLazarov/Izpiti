using System;
class Пътешествие
{
    static void Main(string[] args)
    {
        decimal biudjet = decimal.Parse(Console.ReadLine());
        string sezon = Console.ReadLine().ToLower();
        string destinaciq = "";
        string vidPochivka = "";
        decimal poharcheno = 0;

        if (biudjet<=100)
        {
            destinaciq = "Bulgaria";
            if (sezon=="summer")
            {
                vidPochivka = "Camp";
                poharcheno = biudjet * 30 / 100;
            }
            else
            {
                vidPochivka = "Hotel";
                poharcheno = biudjet * 70 / 100;
            }
        }
        else if (biudjet<=1000)
        {
            destinaciq = "Balkans";
            if (sezon == "summer")
            {
                vidPochivka = "Camp";
                poharcheno = biudjet * 40 / 100;
            }
            else
            {
                vidPochivka = "Hotel";
                poharcheno = biudjet * 80 / 100;
            }
        }
        else
        {
            destinaciq = "Europe";
            vidPochivka = "Hotel";
            poharcheno = biudjet * 90 / 100;
        }
        Console.WriteLine("Somewhere in {0}",destinaciq);
        Console.WriteLine("{0} - {1:0.00}",vidPochivka,poharcheno);

    }
}

