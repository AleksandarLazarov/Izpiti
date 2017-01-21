using System;
class Program
    {
        static void Main(string[] args)
        {
        int candidates = int.Parse(Console.ReadLine());
        int vote = int.Parse(Console.ReadLine());
        string simbol = Console.ReadLine().ToLower();

        string nomerSquare = "";
        int simbolOfRow = 13;
        int rowsInSquare = 3;

        for (int kvadrati = 1; kvadrati <= candidates; kvadrati++)
        {
            if (kvadrati<10)
            {
                nomerSquare = "0" + kvadrati;
            }
            else
            {
                nomerSquare = kvadrati.ToString();
            }

            Console.WriteLine(new String('.', simbolOfRow));
            Console.WriteLine(new String('.', 3) + "+" + new String('-', 5) + "+" + new String('.', 3));
            for (int row = 0; row < rowsInSquare; row++)
            { 
                if(kvadrati==vote)
                { 
                    if (simbol == "x")
                    {
                        if (row == 1)
                        {
                            Console.WriteLine(nomerSquare + ".|..X..|...");
                        }
                        else if(row<1)
                        {
                            
                            Console.WriteLine("...|.\\./.|...");
                        }
                        else
                        {
                            Console.WriteLine("...|./.\\.|...");
                        }
                    }
                    else if (simbol == "v")
                    {
                        if (row==0)
                        {
                            Console.WriteLine("...|\\.../|...");
                        }
                        else if (row == 1)
                        {
                            Console.WriteLine(nomerSquare + ".|.\\./.|...");
                        }
                        else 
                        {
                            Console.WriteLine("...|..V..|...");
                        }
                    }
                }
                else
                {
                    if (row == 1)
                    {
                        Console.WriteLine(nomerSquare + ".|" + new String('.', 5) + "|" + new String('.', 3));
                    }
                    else
                    {
                        Console.WriteLine(new String('.', 3) + "|" + new String('.', 5) + "|" + new String('.', 3));
                    }
                }

            }
            Console.WriteLine(new String('.', 3) + "+" + new String('-', 5) + "+" + new String('.', 3));
        }
        Console.WriteLine(new String('.', simbolOfRow));




    }
}

