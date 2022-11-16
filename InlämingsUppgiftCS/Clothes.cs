using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMaskin;

internal class Clothes : Product
{
    public Clothes(string name, int cost, string descriptions) : base(name, cost, descriptions)
    {

    }
    public override void Description()
    {
        Console.WriteLine($"{this.name} kostar {this.cost}kr. {this.descriptions}. {this.name} är något du har på dig!");
    }
    public override void Buy()
    {
        Console.WriteLine($"Du har köpt {this.name}");
    }
    public override void Use()
    {
        Console.WriteLine($"Du har tagit på dig {this.name}");
    }
}
