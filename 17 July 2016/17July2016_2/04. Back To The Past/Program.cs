using System;
class Program
{
    static void Main(string[] args)
    {
        decimal nasledeniPari = decimal.Parse(Console.ReadLine());
        int poslednaGodina = int.Parse(Console.ReadLine());

        int godiniJivot = poslednaGodina - 1800;
        decimal sumaEven = 0;
        decimal sumaOdd = 0;

        for (int i = 0; i <= godiniJivot; i++)
        {
            if (i%2==0)
            {
                sumaEven += 12000m;
            }
            else
            {
                sumaOdd += 12000m + 50m * (18 + i);
            }
        }

        if (nasledeniPari - (sumaEven + sumaOdd)>=0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", nasledeniPari - (sumaEven + sumaOdd));
        }
        else
        {
            Console.WriteLine("He will need {0:0.00} dollars to survive.", (sumaEven + sumaOdd)-nasledeniPari);
        }
    }
}

