using System;
class Hungry_Garfield
{
    static void Main(string[] args)
    {
        decimal money = decimal.Parse(Console.ReadLine());

        decimal rate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        uint pizzaQuantity = uint.Parse(Console.ReadLine());
        uint lasagnaQuantity = uint.Parse(Console.ReadLine());
        uint sandwichQuantity = uint.Parse(Console.ReadLine());

        decimal sum = pizzaPrice / rate * pizzaQuantity + lasagnaPrice / rate * lasagnaQuantity + sandwichPrice / rate * sandwichQuantity;

        if (sum <= money)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:0.00}.",money - sum);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:0.00}.",sum - money);
        }

    }
}

