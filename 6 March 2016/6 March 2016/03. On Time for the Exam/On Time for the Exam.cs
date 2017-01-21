using System;

public class Program
{
    public static void Main()
    {
        int izpitH = int.Parse(Console.ReadLine());
        int izpitMin = int.Parse(Console.ReadLine());
        int pristH = int.Parse(Console.ReadLine());
        int pristMin = int.Parse(Console.ReadLine());

        int vIzpit = izpitH * 60 + izpitMin;
        int vPrist = pristH * 60 + pristMin;

        if (vIzpit > (vPrist + 30))
        {
            Console.WriteLine("Early");
            if (vIzpit - vPrist < 60) { Console.WriteLine("{0} minutes before the start", vIzpit - vPrist); }
            else if (vIzpit - vPrist == 60) { Console.WriteLine("{0}:00 hours before the start", (vIzpit - vPrist) / 60); }
            else { Console.WriteLine("{0}:{1:00} hours before the start", (vIzpit - vPrist) / 60, (vIzpit - vPrist) % 60); }

        }
        else if (vPrist > vIzpit)
        {
            Console.WriteLine("Late");
            if (vPrist - vIzpit < 60) { Console.WriteLine("{0} minutes after the start", vPrist - vIzpit); }
            else if (vPrist - vIzpit >= 60)
            {
                if ((vPrist - vIzpit) % 60 < 10)
                {
                    Console.WriteLine("{0}:0{1} hours after the start", (vPrist - vIzpit) / 60, (vPrist - vIzpit) % 60);
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours after the start", (vPrist - vIzpit) / 60, (vPrist - vIzpit) % 60);
                }
            }
        }
        else if (vIzpit - vPrist <= 30 && vIzpit - vPrist >= 0)
        {
            Console.WriteLine("On time");
            if (vPrist == vIzpit) { }
            if (vIzpit - vPrist <= 30) { Console.WriteLine("{0} minutes before the start", vIzpit - vPrist); }

        }



    }
}