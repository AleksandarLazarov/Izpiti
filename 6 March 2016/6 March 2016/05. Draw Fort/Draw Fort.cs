using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int shirina = 2 * n;
        int sredniTireta = shirina - 4 - (n / 2) - (n / 2);
        if (n > 4)
        {
            Console.WriteLine("/" + new string('^', n / 2) + "\\" + new string('_', sredniTireta) + "/" + new string('^', n / 2) + "\\");
        }
        else
        {
            Console.WriteLine("/" + new string('^', n / 2) + "\\" + "/" + new string('^', n / 2) + "\\");
        }

        for (int i = 0; i < n-2; i++)
        {
            if (n > 4 && i == (n - 3))
            {
                Console.WriteLine("|" + new string(' ', n / 2 + 1) + new string('_', sredniTireta) + new string(' ', n / 2 + 1) + "|");
            }
            else
            {
                Console.WriteLine("|" + new string(' ', n * 2 - 2) + "|");
            }
        }
        if (n > 4)
        {
            Console.WriteLine("\\" + new string('_', n / 2) + "/" + new string(' ', sredniTireta) + "\\" + new string('_', n / 2) + "/");
        }
        else
        {
            Console.WriteLine("\\" + new string('_', n / 2) + "/" + "\\" + new string('_', n / 2) + "/");
        }

        

    }
}
