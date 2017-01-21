using System;
class HotelRoom
{
    static void Main(string[] args)
    {
        string mesec = Console.ReadLine().ToLower();
        int broiNoshtuvki = int.Parse(Console.ReadLine());

        decimal cenaStdio = 0;
        decimal cenaApart = 0;


        if (mesec == "may" || mesec == "october")
        {
            if (broiNoshtuvki>14)
            {
                cenaStdio = 50m * broiNoshtuvki - ((50m * broiNoshtuvki) * 30 / 100);
                cenaApart = 65m * broiNoshtuvki - ((65m * broiNoshtuvki)*10/100);

            }
            else if (broiNoshtuvki > 7)
            {
                cenaStdio = 50m * broiNoshtuvki - ((50m * broiNoshtuvki) * 5 / 100);
                cenaApart = 65m * broiNoshtuvki;

            }
            else
            {
                cenaStdio = 50m * broiNoshtuvki;
                cenaApart = 65m * broiNoshtuvki;

            }
        }
        else if (mesec == "june" || mesec == "september")
        {
            if (broiNoshtuvki > 14)
            {
                cenaStdio = 75.20m * broiNoshtuvki - ((75.20m * broiNoshtuvki) * 20 / 100);
                cenaApart = 68.70m * broiNoshtuvki - ((68.70m * broiNoshtuvki) * 10 / 100);

            }
            else
            {
                cenaStdio = 75.20m * broiNoshtuvki;
                cenaApart = 68.70m * broiNoshtuvki;

            }
        }
        else if (mesec == "july" || mesec == "august")
        {
            cenaStdio = 76m * broiNoshtuvki;
            cenaApart = 77m * broiNoshtuvki;
            if (broiNoshtuvki > 14)
            {
                cenaApart = 77m * broiNoshtuvki - ((77m * broiNoshtuvki) * 10 / 100);
            }

        }

        Console.WriteLine("Apartment: {0:0.00} lv.", cenaApart);
        Console.WriteLine("Studio: {0:0.00} lv.", cenaStdio);
    }
}

