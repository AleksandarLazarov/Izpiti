using System;
class Program
{
    static void Main(string[] args)
    {
        int obemBasein = int.Parse(Console.ReadLine());
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        double chasove = double.Parse(Console.ReadLine());

        double vodaObshto = p1 * chasove + p2 * chasove;
        double debitP1 =  p1 * chasove * 100/ vodaObshto;
        double debitP2 = p2 * chasove * 100 / vodaObshto;


        if (obemBasein>=vodaObshto)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Floor(vodaObshto*100/ obemBasein), Math.Floor(debitP1), Math.Floor(debitP2));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",chasove,vodaObshto-obemBasein);
        }

    }
}

