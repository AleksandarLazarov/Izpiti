using System;
class Program
{
    static void Main(string[] args)
    {
        int varast = int.Parse(Console.ReadLine());
        decimal peralnqCena = decimal.Parse(Console.ReadLine());
        int edCenaIgra = int.Parse(Console.ReadLine());
        int broiIgrachki = 0;
        decimal sumaOtRD = 0;
        decimal paziZaRD = 10;
        decimal pariZaBrat = 0;
        for (int godini = 1; godini <= varast; godini++)
        {
            if (godini%2==0)
            {
                sumaOtRD += paziZaRD;
                paziZaRD += 10;
                pariZaBrat++;
            }
            else
            {
                broiIgrachki++;
            }
        }

        decimal ostatak = peralnqCena - ((sumaOtRD-pariZaBrat)+broiIgrachki*edCenaIgra);

        if (ostatak <= 0)
        {
            Console.WriteLine("Yes! {0:0.00}", Math.Abs(ostatak));
        }
        else
        {
            Console.WriteLine("No! {0:0.00}",ostatak);   
        }

    }
}

