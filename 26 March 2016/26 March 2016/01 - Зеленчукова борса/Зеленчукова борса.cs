using System;
class Program
{
    static void Main(string[] args)
    {
        decimal cenaZelenchuci = decimal.Parse(Console.ReadLine());
        decimal cenaPlodove = decimal.Parse(Console.ReadLine());
        int kgZelenchuc = int.Parse(Console.ReadLine());
        int kgPlodove = int.Parse(Console.ReadLine());

        decimal sumaLv = cenaZelenchuci * kgZelenchuc + cenaPlodove * kgPlodove;
        Console.WriteLine("{0}",sumaLv/1.94m);
    }
}

