using System;
class Program
{
    static void Main(string[] args)
    {
        decimal stroiteli = decimal.Parse(Console.ReadLine());
        decimal recepcionist = decimal.Parse(Console.ReadLine());
        decimal kamerierki = decimal.Parse(Console.ReadLine());
        decimal tehnici = decimal.Parse(Console.ReadLine());
        decimal drugi = decimal.Parse(Console.ReadLine());
        decimal nikiZaplata = decimal.Parse(Console.ReadLine());
        decimal kursDolar = decimal.Parse(Console.ReadLine());
        decimal moqZaplata = decimal.Parse(Console.ReadLine());
        decimal biudjet = decimal.Parse(Console.ReadLine());
        
        nikiZaplata = nikiZaplata * kursDolar;
        
        decimal razhodi = stroiteli * 1500.04m + recepcionist * 2102.10m + kamerierki * 1465.46m + 
            tehnici * 2053.33m + drugi * 3010.98m + nikiZaplata + moqZaplata;

        Console.WriteLine("The amount is: {0:0.00} lv.",razhodi);
        if (biudjet<razhodi)
        {
            Console.WriteLine("NO \\ Need more: {0:0.00} lv.",razhodi - biudjet);
        }
        else
        {
            Console.WriteLine("YES \\ Left: {0:0.00} lv.",biudjet - razhodi);
        }


    }
}

