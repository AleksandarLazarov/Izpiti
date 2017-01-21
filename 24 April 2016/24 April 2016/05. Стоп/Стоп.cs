using System;
class Стоп
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int coloni = n * 4 + 3;
        int redove = n * 2 + 2;
        int sredniTireta = n * 2 - 1;
        int tochki = n;
        Console.WriteLine(new string('.',n+1) + new string('_', n*2 + 1) + new string('.', n + 1));
        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine(new string('.',tochki) + "//" + new string('_', sredniTireta) + "\\\\" + new string('.', tochki));
            tochki--;
            sredniTireta += 2;
        }
        Console.WriteLine("//" + new string('_', (coloni-9)/2) + "STOP!" + new string('_', (coloni - 9) / 2) + "\\\\");
        //Sreda

        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine(new string('.', tochki) + "\\\\" + new string('_', sredniTireta) + "//" + new string('.', tochki));
            tochki++;
            sredniTireta -= 2;
        }
    }
}

