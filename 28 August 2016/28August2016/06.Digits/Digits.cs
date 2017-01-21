using System;
class Digits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstDigit = n % 1000 / 100;
        int secondDigit = n % 100 / 10;
        int thirthDigit = n % 10;

        for (int row = 0; row < firstDigit + secondDigit ; row++)
        {
            for (int col = 0; col < firstDigit + thirthDigit; col++)
            {
                if (n%5==0)
                {
                    n -= firstDigit;
                }
                else if (n%3==0)
                {
                    n -= secondDigit;
                }
                else
                {
                    n += thirthDigit;
                }
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

    }
}

