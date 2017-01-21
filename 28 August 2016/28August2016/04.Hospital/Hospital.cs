using System;
class Hospital
{
    static void Main(string[] args)
    {
        int period = int.Parse(Console.ReadLine());
        int pacientiNaDen;

        int lekari = 7;
        int pregledaniPac = 0;
        int nePregledPac = 0;
        int n = 3;

        for (int i = 1; i <= period; i++)
        {
            pacientiNaDen = int.Parse(Console.ReadLine());
            if (i % 3 == 0 && pregledaniPac < nePregledPac)
            {
                lekari++;
            }
            if (pacientiNaDen>lekari)
            {
                nePregledPac += pacientiNaDen - lekari;
                pregledaniPac += lekari;
            }
            else
            {
                pregledaniPac += pacientiNaDen;
            }
            
        }

        Console.WriteLine("Treated patients: {0}.", pregledaniPac);
        Console.WriteLine("Untreated patients: {0}.", nePregledPac);
    }
}

