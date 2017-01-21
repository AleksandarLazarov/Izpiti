using System;
class Program
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        for (int i1 = a; i1 <= b; i1++)
        {
            for (int i2 = a+1; i2 <= b; i2++)
            {
                for (int i3 = a+2; i3 <= b; i3++)
                {
                    for (int i4 = a+3; i4 <= b; i4++)
                    {
                        Console.WriteLine("{0} {1} {2} {3}",i1,i2,i3,i4);
                    }
                }
            }
        }



    }
}

