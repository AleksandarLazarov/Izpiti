using System;
class Пеперуда
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int koloni = 2 * n - 1;
        int redove = 2 * (n - 2) + 1;
        int strana = n - 1;

        for (int i = 0; i <= redove/2-1; i++)
        {
            if (i%2==0)
            {
                Console.WriteLine(new string('*',n-2) + "\\ /" + new string('*', n - 2));
            }
            else
            {
                Console.WriteLine(new string('-', n - 2) + "\\ /" + new string('-', n - 2));
            }
        }
        Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));
        for (int i = 0; i <= redove / 2 - 1; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(new string('*', n - 2) + "/ \\" + new string('*', n - 2));
            }
            else
            {
                Console.WriteLine(new string('-', n - 2) + "/ \\" + new string('-', n - 2));
            }
        }


    }
}

