using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int koloni = n * 2;
        int redoveCetni = n - 1;
        int redoveNeCetni = n;
        int prazni = n - 2;

        Console.WriteLine(new String('%', koloni));
        if (n % 2 == 0)
        {
            for (int i = 1; i <= redoveCetni; i++)
            {
                if (n/2==i)
                {
                    Console.WriteLine("%" + new String(' ', prazni) + "**" + new String(' ', prazni) + "%");
                }
                else
                {
                    Console.WriteLine("%" + new String(' ', koloni-2) + "%");
                }
            }
        }
        if (n % 2 == 1)
        {
            for (int i = 1; i <= redoveNeCetni; i++)
            {
                if (n/2+1 == i)
                {
                    Console.WriteLine("%" + new String(' ', prazni) + "**" + new String(' ', prazni) + "%");
                }
                else
                {
                    Console.WriteLine("%" + new String(' ', koloni - 2) + "%");
                }
            }
        }


        Console.WriteLine(new String('%', koloni));
    }
}

