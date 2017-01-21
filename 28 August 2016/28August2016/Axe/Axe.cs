using System;
class Axe
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int col = 5 * n;

        int row = n * 2;
        if (n%2==1)
        {
            row = n * 2 - 1;
        }
        int srednoTire = 0;
        int posledniTireta = col - (n * 3 + 2);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('-',n*3) + "*" + new string('-',srednoTire) + "*" + new string('-', posledniTireta));
            posledniTireta--;
            srednoTire++;
        }
        //gorna chast
        int drajka = row - (n/2+n);
        for (int i = 0; i < drajka; i++)
        {
            Console.WriteLine(new string('*',n*3+1) + new string('-',srednoTire-1) + "*" + new string('-', posledniTireta+1));
        }
        //drajka
        int parviTireta = n * 3;
        for (int i = 0; i < drajka-1; i++)
        {
            Console.WriteLine(new string('-', parviTireta) + "*" + new string('-', srednoTire - 1) + "*" + new string('-', posledniTireta + 1));
            srednoTire += 2;
            posledniTireta--;
            parviTireta--;
        }
        Console.WriteLine(new string('-', parviTireta) + new string('*', srednoTire + 1) + new string('-', posledniTireta + 1));





    }
}

