using System;
class Program
{
    static void Main(string[] args)
    {
        int dnaPlosht = int.Parse(Console.ReadLine());
        double shirPlo = double.Parse(Console.ReadLine());
        double dnaPlo = double.Parse(Console.ReadLine());
        int shirPeika = int.Parse(Console.ReadLine());
        int dnaPeika = int.Parse(Console.ReadLine());

        double ploshtPloshtadka = dnaPlosht * dnaPlosht;
        double ploshtPeika = shirPeika * dnaPeika;
        double ploshtPlochka = shirPlo * dnaPlo;

        Console.WriteLine((ploshtPloshtadka - ploshtPeika) / ploshtPlochka);
        Console.WriteLine((ploshtPloshtadka - ploshtPeika) / ploshtPlochka * 0.2);
        for
    }
}

