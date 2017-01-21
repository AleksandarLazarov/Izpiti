using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int col = 5 * n;
        int tochki = n - 1;
        int row = 3 * n + 2;
        Console.WriteLine(new string('.',n) + new string('*', n*3) + new string('.', n));
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine(new string('.', tochki) + "*" + new string('.', col-((tochki*2)+2)) + "*" + new string('.', tochki));
            tochki--;

        }
        Console.WriteLine(new string('*', col));
        //gorna chast
        for (int i = 0; i < row-(n+1); i++)
        {
            tochki++;
            if (tochki == n * 2 + 1)
            {
                Console.WriteLine(new string('.', tochki) + new string('*', n-2) + new string('.', tochki));
            }
            else
            {
                Console.WriteLine(new string('.', tochki) + "*" + new string('.', col - ((tochki * 2) + 2)) + "*" + new string('.', tochki));
            }
        }

    }
}

