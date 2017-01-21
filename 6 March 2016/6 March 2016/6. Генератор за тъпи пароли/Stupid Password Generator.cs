using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int bukvi = 97 + l;
        
        for (int i1 = 1; i1 < n; i1++)
        {
            for (int i2 = 1; i2 < n; i2++)
            {
                for (char i3 = 'a'; i3 < bukvi; i3++)
                {
                    for (char i4 = 'a'; i4 < bukvi; i4++)
                    {
                        for (int i5 = Math.Max(i1, i2) + 1; i5 <= n; i5++)
                        {
                            Console.Write(i1);
                            Console.Write(i2);
                            Console.Write(i3);
                            Console.Write(i4);
                            Console.Write(i5 + " ");

                        }
                    }
                }

            }
        }
    }
}

