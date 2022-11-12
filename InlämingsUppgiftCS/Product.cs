using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämingsUppgiftCS;

internal abstract class Product : IProduct
{
    //Property
    public string Name { get; set; }
    public int Cost { get; set; }
    public string Descriptions { get; set; }

    //Konstruktor
    public Product(string name, int cost, string descriptions)
    {
        this.Name = name;
        this.Cost = cost;
        this.Descriptions = descriptions;
    }

    public virtual void Description()
    {
        Console.WriteLine($"{this.Descriptions}. Detta är bas beskrivning");
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