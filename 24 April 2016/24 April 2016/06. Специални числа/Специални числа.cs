using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1111; i <= 9999; i++)
        {
            if (i % 10 != 0 && i % 100 / 10 != 0 && i % 1000 / 100 != 0 && i % 10000 / 1000 != 0)
            {
                if (n % (i % 10) == 0 && n % (i % 100 / 10) == 0 && n % (i % 1000 / 100) == 0 && n % (i % 10000 / 1000) == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }  
        
    }
}

