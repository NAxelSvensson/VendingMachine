using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMaskin;

internal abstract class Product : IProduct
{
    //Attribut
    public string name;
    public int cost;
    public string descriptions;

    //Konstruktor
    public Product(string name, int cost, string descriptions)
    {
        this.name = name;
        this.cost = cost;
        this.descriptions = descriptions;
    }
    public virtual void Description()
    {
        Console.WriteLine($"{this.descriptions}. Detta är bas beskrivning");
    }

    public virtual void Buy()
    {
        Console.WriteLine("Detta är bas köp");
    }

    public virtual void Use()
    {
        Console.WriteLine("Detta är bas användning");
    }
}