using System;
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("*");
        }
        else
        {
            int n2 = n - 1;
            Console.WriteLine(new String(' ', n - 1) + "*");
            for (int row = 1; row < n; row++)
            {
                Console.Write(new String(' ', n - row - 1) + "*");
                for (int i = 0; i < row; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            //------
            for (int row = n2; row > 1; row--)
            {
                Console.Write(new String(' ', n - row) + "*");
                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new String(' ', n - 1) + "*");
        }
    }
}
