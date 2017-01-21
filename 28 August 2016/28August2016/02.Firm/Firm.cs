using System;
class Firm
{
    static void Main(string[] args)
    {
        int nujniChasove = int.Parse(Console.ReadLine());
        int dniNaRazpolojenie = int.Parse(Console.ReadLine());
        int rabotnoiciIzvanredn = int.Parse(Console.ReadLine());
        double rabotniDni = dniNaRazpolojenie-(dniNaRazpolojenie * 10d / 100);

       double chasoveRabota = Math.Truncate(rabotniDni *8+ rabotnoiciIzvanredn * 2* dniNaRazpolojenie);

        if (chasoveRabota>=nujniChasove)
        {
            Console.WriteLine("Yes!{0} hours left.", chasoveRabota - nujniChasove);
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", nujniChasove - chasoveRabota);
        }


    }
}

