using System;
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int lastNum = 0;
        int daljinaNaRedicata = 0;
        int staraDaljina = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (lastNum >= num)
            {
                daljinaNaRedicata = 0;
            }

            daljinaNaRedicata++;
            if (staraDaljina < daljinaNaRedicata)
            {
                staraDaljina = daljinaNaRedicata;
            }
            lastNum = num;
        }
        Console.WriteLine(staraDaljina);

    }
}
