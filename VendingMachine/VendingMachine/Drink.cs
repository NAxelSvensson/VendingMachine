using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine;

internal class Drink : Product, IProduct
{
    public Drink(string name, int cost, string descriptions) : base(name, cost, descriptions)
    {

    }
    //Metod för beskrivningen och kostnad
    public override void Description()
    {
        Console.WriteLine($"{name} kostar {cost}kr. {descriptions}. {name} är något du dricker!");
    }
    //Metod för att visa att man har köpt produkten
    public override void Buy()
    {
        Console.WriteLine($"Du har köpt {name}");
    }
    //Metod för att visa att man har använt produkten
    public override void Use()
    {
        Console.WriteLine($"Du har druckit {name}");
    }
}
