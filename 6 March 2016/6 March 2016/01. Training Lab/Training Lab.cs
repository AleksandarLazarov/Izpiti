using System;
class Program
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine())*100;
        double height = double.Parse(Console.ReadLine())*100;
        int biuraNaRed = ((int)height - 100)/70;
        int redove = (int)width / 120;
        int obshtoMesta = biuraNaRed * redove;


        Console.WriteLine("{0}", obshtoMesta - 3);

    }
}

