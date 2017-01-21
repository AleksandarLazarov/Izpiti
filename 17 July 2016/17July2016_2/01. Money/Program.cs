using System;
class Money
{
    static void Main(string[] args)
    {
        int bitcoin = int.Parse(Console.ReadLine());
        decimal iuan = decimal.Parse(Console.ReadLine());
        decimal komisionna = decimal.Parse(Console.ReadLine());

        decimal evroBitcoin = bitcoin * 1168m;
        decimal evroIuan = (iuan * 0.15m) * 1.76m;
        decimal sum = (evroBitcoin + evroIuan) / 1.95m;

        decimal komis = sum * komisionna / 100;
        Console.WriteLine("{0}", (double)sum - (double)komis);
    }
}