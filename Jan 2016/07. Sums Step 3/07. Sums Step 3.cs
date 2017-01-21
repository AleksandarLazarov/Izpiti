using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;

        int iSum1 = 1;
        int iSum2 = 2;
        int iSum3 = 3;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (iSum1 == i)
            {
                sum1 += num;
                iSum1 += 3;
            }
            if (iSum2 == i)
            {
                sum2 += num;
                iSum2 += 3;
            }
            if (iSum3 == i)
            {
                sum3 += num;
                iSum3 += 3;
            }

        }

        Console.WriteLine($"sum1 = {sum1}");
        Console.WriteLine($"sum2 = {sum2}");
        Console.WriteLine($"sum3 = {sum3}");
    }
}

