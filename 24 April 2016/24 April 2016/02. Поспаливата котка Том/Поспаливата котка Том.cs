using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int norma = 30000;
        int rabotniDni = 365 - n;
        int vremeZaIgra = rabotniDni * 63 + n * 127;
        if (norma<vremeZaIgra)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play",(vremeZaIgra-norma)/60, (vremeZaIgra - norma) % 60);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", (norma- vremeZaIgra) / 60, (norma - vremeZaIgra) % 60);
        }
    }
}

