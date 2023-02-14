using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine;

class VendingMachine
{
    public void Run()
    {
        //Variabel för felmedelande
        const string felMessage = "Ditt val var ogiltligt";
        //Hämta listan från en metod
        Product[] productList = InitProductList();

        //Loop för meny
        while (true)
        {
            //Visar meny
            ShowMenu(productList);
            //Väljer produkt
            var choice = ReadChoice("Ditt val: ");
            if (choice < 0 || choice > productList.Length)
            {
                ShowError(felMessage);
                continue;
            }

            //Ett sätt att avsluta på
            if (choice == productList.Length)
            {
                break;
            }
            //Variabel för vald produkt
            var choosenProduct = productList[choice];
            while (true)
            {
                Console.Clear();
                choosenProduct.Description();
                var buyOrNot = BuyOrNot();

                //Om man väljer att köpa produkten
                if (buyOrNot == 0)
                {
                    Console.Clear();
                    choosenProduct.Buy();
                    choosenProduct.Use();
                    Console.Write("Tryck på vilken tangent för att gå tillbaka: ");
                    Console.ReadKey(true);
                    break;
                }
                //Om man inte vill köpa produkten och gå tillbaka
                else if (buyOrNot == 1)
                {
                    break;
                }
                //Om man råkade skriva ett nummer som inte är 1 eller 2
                else
                {
                    ShowError(felMessage);
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
        new Food("Banan", 10, "Den är söt och gul"),
        new Food("Äpple", 8, "Den är röd och krispig"),
        new Food("Choklad", 25, "Den är väldigt söt"),
        new Food("Korv", 15, "Den kommer med bröd och ketchup"),

        new Drink("Fanta", 20, "Den smakar apelsin"),
        new Drink("Vatten", 15, "Det är vanligt vatten"),
        new Drink("Kaffe", 18, "Den ger dig energi"),
        new Drink("Pucko", 16, "Det är en chocklad dricka"),

        new Clothes("Tröja", 150, "Det är en fluffig tröja"),
        new Clothes("Jeans", 250, "Det är ett par blå jeans"),
        new Clothes("Skjorta", 300, "Det är en blommig skjorta"),
        new Clothes("Tofflor", 100, "Det är ett par mysiga tofflor")
        };
    }
    //Metod för att visa huvud meny
    static void ShowMenu(Product[] productList)
    {
        Console.Clear();
        Console.WriteLine("Meny");
        Console.WriteLine("=================");
        for (int i = 0; i < productList.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {productList[i].name}");
        }
        Console.WriteLine($"{productList.Length + 1}. Avsluta");
    }
    //Metod för sina val
    static int ReadChoice(string message, int maxChoice = int.MaxValue)
    {
        Console.Write(message);
        var input = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrEmpty(input))
            input = "0";

        var choice = int.Parse(input);
        return choice - 1;
    }

    //Metod för att köpa eller inte
    static int BuyOrNot()
    {
        Console.WriteLine("1. Köp");
        Console.WriteLine("2. Gå tillbaka");

        return ReadChoice("Ditt val: ", 2);
    }
    //Metod för att visa felmedelande
    static void ShowError(string message)
    {
        Console.Write($"{message}. Tryck på vilken tangent för att fortsätta...");
        Console.ReadKey(true);
    }
}
