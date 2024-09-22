using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cow : Animal
{
    private static Random random = new Random();

    public Cow(int quantity) : base(quantity, "Cow") { }

    public override string MakeSound()
    {
        return "Moo!";
    }

    public override int ProduceMilk()
    {
        // Random milk between 0 and 20 liters for each cow
        int milk = 0;
        for (int i = 0; i < Quantity; i++)
        {
            milk += random.Next(0, 21);
        }
        return milk;
    }

    public override int GiveBirth()
    {
        // Random birth count for each cow
        int offspring = 0;
        for (int i = 0; i < Quantity; i++)
        {
            offspring += random.Next(1, 4); // Each cow gives 1-3 offspring
        }
        return offspring;
    }
}
