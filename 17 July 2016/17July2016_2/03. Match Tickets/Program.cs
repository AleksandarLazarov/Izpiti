using System;
class Program
{
    static void Main(string[] args)
    {
        decimal biudjet = decimal.Parse(Console.ReadLine());
        string kategoriq = Console.ReadLine().ToLower();
        int broiHora = int.Parse(Console.ReadLine());
        decimal pariZaTransport = 0;
        decimal pariZaBileti = broiHora * 249.99m;
        decimal result = 0;

        if (kategoriq == "vip")
        {
            pariZaBileti = broiHora * 499.99m;
        }

        if (broiHora > 0 && broiHora < 5)
        {
            pariZaTransport = biudjet * 75 / 100;
            if (biudjet - (pariZaBileti + pariZaTransport) >= 0)
            {
                result = biudjet - (pariZaBileti + pariZaTransport);
            }
            else
            {
                result = (pariZaBileti + pariZaTransport) - biudjet;
            }
        }
        else if (broiHora > 4 && broiHora < 10)
        {
            pariZaTransport = biudjet * 60 / 100;
            if (biudjet - (pariZaBileti + pariZaTransport) >= 0)
            {
                result = biudjet - (pariZaBileti + pariZaTransport);
            }
            else
            {
                result = (pariZaBileti + pariZaTransport) - biudjet;
            }
        }
        else if (broiHora > 9 && broiHora < 25)
        {
            pariZaTransport = biudjet * 50 / 100;
            if (biudjet - (pariZaBileti + pariZaTransport) >= 0)
            {
                result = biudjet - (pariZaBileti + pariZaTransport);
            }
            else
            {
                result = (pariZaBileti + pariZaTransport) - biudjet;
            }
        }
        else if (broiHora > 24 && broiHora < 50)
        {
            pariZaTransport = biudjet * 40 / 100;
            if (biudjet - (pariZaBileti + pariZaTransport) >= 0)
            {
                result = biudjet - (pariZaBileti + pariZaTransport);
            }
            else
            {
                result = (pariZaBileti + pariZaTransport) - biudjet;
            }
        }
        else if (broiHora >= 50)
        {
            pariZaTransport = biudjet * 25 / 100;
            if (biudjet - (pariZaBileti + pariZaTransport) >= 0)
            {
                result = biudjet - (pariZaBileti + pariZaTransport);
            }
            else
            {
                result = (pariZaBileti + pariZaTransport) - biudjet;
            }
        }

        if (biudjet - (pariZaBileti + pariZaTransport) >= 0)
        {
            Console.WriteLine("Yes! You have {0:0.00} leva left.", biudjet - (pariZaBileti + pariZaTransport));
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:0.00} leva.", (pariZaBileti + pariZaTransport) - biudjet);
        }
    }
}

