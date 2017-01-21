using System;

namespace GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            // От конзолата се въвеждат две числа, по едно на ред:
            //•	Цяло число n в интервала[1…100] – задава минималната и максималната координата на връх.
            //•	Цяло число m в интервала[0…50000] – задава минималната площ на генерираните правоъгълници.
            //Изход
            //•	На конзолата трябва да се отпечатат описаните правоъгълници във формат като в примерите по-долу.
            //•	Ако за числата n и m няма нито един правоъгълник, да се изведе “No”.
            //•	Редът на извеждане на правоъгълниците е без значение.

            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            bool found = false;

            for (int left = -n; left <= 0; left++)
            {
                for (int right = n; right >= 0; right--)
                {
                    for (int top = -n; top <= 0; top++)
                    {
                        for (int bottom = n; bottom >= 0; bottom--)
                        {
                            if (-n <= left && left < right && right <= n && -n <= top && top < bottom && bottom <= n)
                            {
                                int sideOne = Math.Abs(left) + Math.Abs(right);
                                int sideTwo = Math.Abs(top) + Math.Abs(bottom);

                                if (sideOne * sideTwo >= m)
                                {

                                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, sideOne * sideTwo);
                                    found = true;
                                }
                                
                            }
                        }
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }

        }
    }
}
