using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Animal
{
    public int Quantity { get; set; }
    public string Name { get; set; }

    public Animal(int quantity, string name)
    {
        Quantity = quantity;
        Name = name;
    }

    // Abstract methods for milk and sound
    public abstract string MakeSound();
    public abstract int ProduceMilk();
    public abstract int GiveBirth();
}
