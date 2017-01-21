using System;
class Harvest
{
    static void Main(string[] args)
    {
        int ploshLoze = int.Parse(Console.ReadLine());
        double grozdeNaMetar = double.Parse(Console.ReadLine());
        int nujnoVino = int.Parse(Console.ReadLine());
        int rabotnici = int.Parse(Console.ReadLine());

        double kgZaVino = (ploshLoze * 40 / 100) * grozdeNaMetar;
        double litriVino = kgZaVino / 2.5;

        if (nujnoVino > litriVino)
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(nujnoVino - litriVino));
        }
        else
        {
            double vinoZaRabotnik = (litriVino - nujnoVino) / rabotnici;
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Truncate(litriVino));
            Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(litriVino - nujnoVino), Math.Ceiling(vinoZaRabotnik));
        }

    }
}

