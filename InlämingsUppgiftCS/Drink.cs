using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMaskin;

internal class Drink : Product, IProduct
{
    public Drink(string name, int cost, string descriptions) : base(name, cost, descriptions)
    {

    }
    public override void Description()
    {
        Console.WriteLine($"{this.Name} kostar {this.Cost}kr. {this.Descriptions}. {this.Name} är något du dricker!");
    }
    public override void Buy()
    {
        Console.WriteLine($"Du har köpt {this.Name}");
    }
    public override void Use()
    {
        Console.WriteLine($"Du har druckit {this.Name}");
    }
}
