using System;
class Program
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        string operaciq = Console.ReadLine();
        int rezultat = n1 + n2;
        string evenOdd = "";
        if (operaciq == "+")
        {
            if (rezultat % 2 == 0)
            {evenOdd = "even";}
            else
            {evenOdd = "odd"; }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operaciq, n2, rezultat, evenOdd);

        }
        else if (operaciq == "-")
        {
            rezultat = n1-n2;
            if (rezultat % 2 == 0)
            { evenOdd = "even"; }
            else
            { evenOdd = "odd"; }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operaciq, n2, rezultat, evenOdd);

        }
        else if (operaciq == "*")
        {
            rezultat = n1* n2;
            if (rezultat % 2 == 0)
            { evenOdd = "even"; }
            else
            { evenOdd = "odd"; }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operaciq, n2, rezultat, evenOdd);

        }
        else if (operaciq == "/")
        {
            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2:0.00}", n1, n2, (double)n1 / n2);
            }
        }
        else if (operaciq == "%")
        {
            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {
                Console.WriteLine("{0} % {1} = {2}", n1, n2, (double)n1 % n2);
            }
        }

    }
}
