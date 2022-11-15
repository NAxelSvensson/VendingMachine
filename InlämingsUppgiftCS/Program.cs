using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace InlämingsUppgiftCS;
internal class Program
{
    static void Main(string[] args)
    {
        //Hämta listan från en metod
        Product[] productList = InitProductList();

        //Loop för meny
        while (true)
        {
            //Visar meny
            ShowMenu(productList);
            //Väljer produkt
            var choice = YourChoice("Ditt val: ");
            //Ett sätt att avsluta på
            if (choice == productList.Length)
            {
                break;
            }
            Console.Clear();
            //Variabel för vald produkt
            var choosenProduct = productList[choice];
            while (true)
            {
                choosenProduct.Description();
                var buyOrNot = BuyOrNot();
                Console.Clear();
                //Om man väljer att köpa produkten
                if (buyOrNot == 1)
                {
                    choosenProduct.Buy();
                    choosenProduct.Use();
                    Console.Write("Tryck Enter för att gå tillbaka: ");
                    Console.ReadLine();
                    break;
                }
                //Om man inte vill köpa produkten och gå tillbaka
                else if (buyOrNot == 2)
                {
                    break;
                }
                //Om man råkade skriva ett nummer som inte är 1 eller 2
                else
                {
                    Console.WriteLine("Ditt val var ogiltligt");
                    continue;
                }
            }
        }
    }
    //Metod för en lista
    static Product[] InitProductList()
    {
        return new Product[]
        {
            //Objekt för varor
            new Food("Banan", 10, "Detta är en banan"),
            new Food("Äpple", 8, "Detta är ett äpple"),
            new Food("Choklad", 25, "Detta är ett choklad"),
            new Food("Korv", 15, "Detta är en korv"),

            new Drink("Fanta", 20, "Detta är en fanta"),
            new Drink("Vatten", 15, "Detta är en vatten"),
            new Drink("Kaffe", 18, "Detta är en kaffe"),
            new Drink("Pucko", 16, "Detta är en pucko"),

            new Clothes("Tröja", 150, "Detta är en t-shirt"),
            new Clothes("Jeans", 250, "Detta är jeans"),
            new Clothes("Skjorta", 300, "Detta är en skjorta"),
            new Clothes("Tofflor", 100, "Detta är tofflor"),
        };
    }
    //Metod för att visa huvud meny
    static void ShowMenu(Product[] productList)
    {
        Console.Clear();
        Console.WriteLine("Meny");
        Console.WriteLine("=================");
        for (int i = 0; i<productList.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {productList[i].Name}");
        }
        Console.WriteLine($"{productList.Length + 1}. Avsluta");
    }
    //Metod för sina val
    static int YourChoice(string message)
    {
        Console.Write(message);
        var choice = int.Parse(Console.ReadLine());
        return choice - 1;
    }
    //Metod för att köpa eller inte
    static int BuyOrNot()
    {
        Console.WriteLine("1. Köp");
        Console.WriteLine("2. Gå tillbaka");
        Console.Write("Ditt val: ");
        var choice = int.Parse(Console.ReadLine() ?? string.Empty);
        return choice;
    }
}