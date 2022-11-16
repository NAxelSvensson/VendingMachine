using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMaskin;

internal class Drink : Product
{
    public Drink(string name, int cost, string descriptions) : base(name, cost, descriptions)
    {

    }
    public override void Description()
    {
        Console.WriteLine($"{this.name} kostar {this.cost}kr. {this.descriptions}. {this.name} är något du dricker!");
    }
    public override void Buy()
    {
        Console.WriteLine($"Du har köpt {this.name}");
    }
    public override void Use()
    {
        Console.WriteLine($"Du har druckit {this.name}");
    }
}
