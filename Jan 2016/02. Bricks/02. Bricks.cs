using System;
class Program
{
    static void Main(string[] args)
    {
        double tuhli = double.Parse(Console.ReadLine());
        double rabotnici = double.Parse(Console.ReadLine());
        double vmestimostRK1K = double.Parse(Console.ReadLine());

        double tuhliNaKurs = rabotnici * vmestimostRK1K;
        double kursove = tuhli / tuhliNaKurs;
        Console.WriteLine(Math.Ceiling(kursove));
    }
}

