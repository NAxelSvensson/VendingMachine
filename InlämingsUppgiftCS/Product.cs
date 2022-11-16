using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift;

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
    //Metod för beskrivningen och kostnad
    public virtual void Description()
    {
        Console.WriteLine($"{this.name} kostar {this.cost}kr. {this.descriptions}. Detta är bas beskrivning");
    }
    //Metod för att visa att man har köpt produkten
    public virtual void Buy()
    {
        Console.WriteLine("Detta är bas köp");
    }
    //Metod för att visa att man har använt produkten
    public virtual void Use()
    {
        Console.WriteLine("Detta är bas användning");
    }
}