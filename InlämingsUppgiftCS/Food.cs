﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämingsUppgiftCS;

internal class Food : Product, iProduct
{
    public Food(string name, int cost, string descriptions) : base(name, cost, descriptions)
    {

    }
    public override void Description()
    {
        Console.WriteLine($"{this.Descriptions}. {this.Name} är något du äter!");
    }
    public override void Buy()
    {
        Console.WriteLine($"Du har köpt {this.Name}");
    }
    public override void Use()
    {
        Console.WriteLine($"Du har ättit {this.Name}");
    }
}
